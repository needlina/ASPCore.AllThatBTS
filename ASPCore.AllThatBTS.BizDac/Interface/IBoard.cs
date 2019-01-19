using ASPCore.AllThatBTS.Model;
using NPoco;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPCore.AllThatBTS.Repository.Interface
{
    interface IBoard
    {
        // 게시물 조회
        Page<Board> SelectBoardDataListWithPage(string boardId, int pageNo = 1, int pageSize = 20);

        Board SelectBoardData(string seq);

        // 게시물 생성
        object InsertBoardData(Board board);

        // 게시물 수정
        int UpdateBoardData(Board board);

        // 게시물 삭제
        int DeleteBoardData(string seq);
    }
}
