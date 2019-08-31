using System;
namespace BookManageSystem.Model
{
    /// <summary>
    /// 实体类CtbBookSort 。
    /// </summary>
    public class CtbBookSort
    {
        public CtbBookSort()
        { }
        #region Model
        private int _booksortid;
        private string _booksortremark;
        /// <summary>
        /// 图书类别编号
        /// </summary>
        public int bookSortID
        {
            set { _booksortid = value; }
            get { return _booksortid; }
        }
        /// <summary>
        /// 类别说明
        /// </summary>
        public string bookSortRemark
        {
            set { _booksortremark = value; }
            get { return _booksortremark; }
        }
        #endregion Model

    }
}