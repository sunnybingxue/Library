using System;
namespace BookManageSystem.Model
{
    /// <summary>
    /// 实体类CtbLend 。
    /// </summary>
    public class CtbLend
    {
        public CtbLend()
        { }
        #region Model
        private int _bookid;
        private int _readerid;
        private int _lendnum;
        private DateTime _lenddate;
        private DateTime _lendydate;
        private string _lendsdate;
        private decimal _lendmulct;
        /// <summary>
        /// 图书编号
        /// </summary>
        public int bookID
        {
            set { _bookid = value; }
            get { return _bookid; }
        }
        /// <summary>
        /// 读者编号
        /// </summary>
        public int readerID
        {
            set { _readerid = value; }
            get { return _readerid; }
        }
        /// <summary>
        /// 借阅数量
        /// </summary>
        public int lendNum
        {
            set { _lendnum = value; }
            get { return _lendnum; }
        }
        /// <summary>
        /// 借阅日期
        /// </summary>
        public DateTime lendDate
        {
            set { _lenddate = value; }
            get { return _lenddate; }
        }
        /// <summary>
        /// 应归还日期
        /// </summary>
        public DateTime lendYDate
        {
            set { _lendydate = value; }
            get { return _lendydate; }
        }
        /// <summary>
        /// 实归还日期
        /// </summary>
        public string lendSDate
        {
            set { _lendsdate = value; }
            get { return _lendsdate; }
        }
        /// <summary>
        /// 罚款金额
        /// </summary>
        public decimal lendMulct
        {
            set { _lendmulct = value; }
            get { return _lendmulct; }
        }
        #endregion Model

    }
}


