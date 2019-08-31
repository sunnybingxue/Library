using System;
namespace BookManageSystem.Model
{
    /// <summary>
    /// 实体类CtbReaderInformation 。
    /// </summary>
    public class CtbReaderInformation
    {
        public CtbReaderInformation()
        { }
        #region Model
        private int _readerid;
        private string _readername;
        private string _readersex;
        private string _readeroffice;
        private string _readerdept;
        private string _readerphone;
        private string _readerhaddress;
        private string _readeremail;
        private DateTime _readerresdate;
        /// <summary>
        /// 读者编号
        /// </summary>
        public int readerID
        {
            set { _readerid = value; }
            get { return _readerid; }
        }
        /// <summary>
        /// 读者姓名
        /// </summary>
        public string readerName
        {
            set { _readername = value; }
            get { return _readername; }
        }
        /// <summary>
        /// 读者性别
        /// </summary>
        public string readerSex
        {
            set { _readersex = value; }
            get { return _readersex; }
        }
        /// <summary>
        /// 读者职务
        /// </summary>
        public string readerOffice
        {
            set { _readeroffice = value; }
            get { return _readeroffice; }
        }
        /// <summary>
        /// 工作单位
        /// </summary>
        public string readerDept
        {
            set { _readerdept = value; }
            get { return _readerdept; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string readerPhone
        {
            set { _readerphone = value; }
            get { return _readerphone; }
        }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string readerHAddress
        {
            set { _readerhaddress = value; }
            get { return _readerhaddress; }
        }
        /// <summary>
        /// E-MAIL
        /// </summary>
        public string readerEmail
        {
            set { _readeremail = value; }
            get { return _readeremail; }
        }
        /// <summary>
        /// 登记日期
        /// </summary>
        public DateTime readerResDate
        {
            set { _readerresdate = value; }
            get { return _readerresdate; }
        }
        #endregion Model

    }
}

