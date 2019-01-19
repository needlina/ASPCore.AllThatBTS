
using ASPCore.AllThatBTS.Common;
using ASPCore.AllThatBTS.Common.Util;
using ASPCore.AllThatBTS.Enum;
using ASPCore.AllThatBTS.Model;
using ASPCore.AllThatBTS.Model.Common;
using ASPCore.AllThatBTS.Repository;
using ASPCore.AllThatBTS.Web.Models;
using Dropbox.Api;
using Dropbox.Api.Files;
using Dropbox.Api.Sharing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using NPoco;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ASPCore.AllThatBTS.Web.Controllers
{
    public class BoardController : Controller
    {
        private readonly BoardRepository boardRepository;

        public BoardController()
        {
            boardRepository = new BoardRepository();
        }

        [HttpGet]
        [Route("Board")]
        public IActionResult Board([FromQuery]string boardId, [FromQuery]int pageNo = 1)
        {
            BoardModel boardModel = new BoardModel();

            #region 게시판 정보 불러오기
            BoardInfo boardInfo = boardRepository.SelectBoardInfo(boardId);

            List<BoardCategoryModel> boardCategoryModelList = new List<BoardCategoryModel>();

            foreach (BoardCategory entity in boardInfo.categoryList)
            {
                BoardCategoryModel boardCategoryModel = new BoardCategoryModel()
                {
                    boardId = entity.boardId,
                    categoryId = entity.categoryId,
                    categoryName = entity.categoryName,
                    categoryType = (CategoryType)EnumHelper.GetEnum(typeof(CategoryType), entity.categoryId)
                };

                boardCategoryModelList.Add(boardCategoryModel);
            }

            BoardInfoModel boardInfoModel = new BoardInfoModel()
            {
                boardId = boardInfo.boardId,
                boardName = boardInfo.boardName,
                categoryList = boardCategoryModelList
            };
            #endregion

            #region 게시판의 게시물 리스트 불러오기
            List<BoardDataModel> boardDataModelList = new List<BoardDataModel>();

            Page<Board> boardList = boardRepository.SelectBoardDataListWithPage(boardId, pageNo);

            long totalItems = boardList.TotalItems;
            long currentPageNo = boardList.CurrentPage;
            long itemsPerPage = boardList.ItemsPerPage;

            long listFirstNum = totalItems - ((currentPageNo - 1) * itemsPerPage);
            foreach (Board entity in boardList.Items)
            {
                BoardDataModel boardDataModel = new BoardDataModel()
                {
                    listNum = listFirstNum,
                    seq = entity.seq,
                    boardId = entity.boardId,
                    categoryId = entity.categoryId,
                    categoryName = EnumHelper.GetDescription(typeof(CategoryType), entity.categoryId),
                    subject = entity.subject,
                    contents = entity.contents,
                    readCount = entity.readCount,
                    recommendCount = entity.recommendCount,
                    commentsCount = entity.commentsCount,
                    nickname = entity.nickname,
                    imageExistYN = entity.imageExistYN,
                    createUser = entity.createUser,
                    createDatetime = entity.createDatetime,
                    updateUser = entity.updateUser,
                    updateDatetime = entity.updateDatetime,
                };
                listFirstNum--;
                boardDataModelList.Add(boardDataModel);
            }
            #endregion

            #region 게시판 페이지 컨트롤
            boardModel.boardInfo = boardInfoModel;
            boardModel.boardDataModelList = new Page<BoardDataModel>()
            {
                ItemsPerPage = boardList.ItemsPerPage,
                TotalItems = boardList.TotalItems,
                TotalPages = boardList.TotalPages,
                CurrentPage = boardList.CurrentPage,
                Items = boardDataModelList
            };
            #endregion

            return View(boardModel);
        }

        [HttpGet]
        [Route("Board/Write/{boardId}")]
        public IActionResult Write(string boardId)
        {
            // 카테고리 리스트 조회
            BoardInfo boardInfo = boardRepository.SelectBoardInfo(boardId);

            List<BoardCategoryModel> categoryModelList = new List<BoardCategoryModel>();

            foreach(BoardCategory entity in boardInfo.categoryList)
            {
                BoardCategoryModel categoryModel = new BoardCategoryModel();
                categoryModel.seq = entity.seq;
                categoryModel.boardId = entity.boardId;
                categoryModel.categoryType = (CategoryType)EnumHelper.GetEnum(typeof(CategoryType), entity.categoryId);
                categoryModel.categoryId = entity.categoryId;
                categoryModel.categoryName = entity.categoryName;
                categoryModelList.Add(categoryModel);
            }

            BoardInfoModel model = new BoardInfoModel()
            {
                boardId = boardInfo.boardId,
                boardName = boardInfo.boardName,
                categoryList = categoryModelList
            };


            return View(model);
        }

        [HttpPost]
        [Route("Board/Write")]
        public IActionResult Write([FromBody]BoardDataModel model)
        {

            ReturnResponse response = new ReturnResponse()
            {
                returnCode = (int)HttpStatusCode.OK,
                ErrorMessage = string.Empty
            };

            try
            {
                Board boardData = new Board()
                {
                    seq = System.Guid.NewGuid().ToString(),
                    boardId = model.boardId,
                    categoryId = model.categoryId,
                    subject = model.subject,
                    contents = model.contents,
                    readCount = 0,
                    recommendCount = 0,
                    commentsCount = 0,
                    imageExistYN = model.imageExistYN,
                    nickname = model.nickname,
                    secret = CryptoHelper.Crypto.HashPassword(model.secret),
                    createUser = "TEST",
                    createDatetime = System.DateTime.Now,
                    updateUser = null,
                    updateDatetime = null
                };

                boardRepository.InsertBoardData(boardData);



            }
            catch (Exception e)
            {
                response.returnCode = (int)HttpStatusCode.BadRequest;
                response.ErrorMessage = e.Message;
                return Json(response);
            }

            return Json(response);


        }



        [Route("Board/View")]
        public IActionResult View([FromQuery]string boardId, [FromQuery]string seq)
        {
            Board boardEntity = boardRepository.SelectBoardData(seq);
            BoardDataModel boardDataModel = new BoardDataModel()
            {
                seq = boardEntity.seq,
                boardId = boardEntity.boardId,
                categoryId = boardEntity.categoryId,
                categoryName = EnumHelper.GetDescription(typeof(CategoryType), boardEntity.categoryId),
                subject = boardEntity.subject,
                contents = boardEntity.contents,
                readCount = boardEntity.readCount,
                recommendCount = boardEntity.recommendCount,
                commentsCount = boardEntity.commentsCount,
                nickname = boardEntity.nickname,
                imageExistYN = boardEntity.imageExistYN,
                createUser = boardEntity.createUser,
                createDatetime = boardEntity.createDatetime,
                updateUser = boardEntity.updateUser,
                updateDatetime = boardEntity.updateDatetime,
            };

            return View(boardDataModel);
        }

        [Route("Board/Edit")]
        public IActionResult Edit(string seq)
        {
            Board boardData = boardRepository.SelectBoardData(seq);

            BoardModel boardModel = new BoardModel();
            return null;
        }

        [HttpPost]
        public JsonResult ImageUpload()
        {
            DropboxClient dropboxClient = new DropboxClient("5JDFm84qP34AAAAAAACSa8H30nIt2ODws2nbvVXAqQEcn7v2uoliJte-EgYrhKo-");

            // 이미지 파일 읽기 - 파일 정보
            var uploadFile = Request.Form.Files[0];
            string fileExt = uploadFile.FileName.Split(".")[1];
            string fileName = string.Format(@"{0}.{1}", Guid.NewGuid(), fileExt);
            Stream fileStream = uploadFile.OpenReadStream();

            // Dropbox Client API에 업로드
            string dropboxPath = @"/" + DateTime.Today.ToShortDateString() + "/" + fileName;
            FileMetadata fileMetaData = dropboxClient.Files.UploadAsync(new CommitInfo(dropboxPath), fileStream).Result;

            // Dropbox Client에 업로드 한 후 공유 링크 URL 생성
            SharedLinkMetadata sharedLinkMetadata = dropboxClient.Sharing.CreateSharedLinkWithSettingsAsync(fileMetaData.PathDisplay).Result;

            // Return URL
            var model = new
            {
                // dl=1로 해야 다운로드 가능하므로 replace 처리
                Url = sharedLinkMetadata.Url.Replace("dl=0", "dl=1")
            };
            return Json(new { Data = model });

        }

    }
}
