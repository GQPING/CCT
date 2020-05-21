﻿using CCT.Resource.Dictionarys;

namespace CCT.ViewModel
{
    /// <summary>
    /// 联系视图模型
    /// </summary>
    public class ContactViewModel : ViewModelBase
    {
        #region 私有域

        private string phone = string.Empty;
        private string e_mail = string.Empty;

        #endregion

        #region 公有属性

        public string Phone
        {
            get { return phone; }
            set { SetProperty(ref phone, value); }
        }

        public string E_mail
        {
            get { return e_mail; }
            set { SetProperty(ref e_mail, value); }
        }

        #endregion

        #region 构造方法

        public ContactViewModel()
        {
            Title = "联系我们-CCT通用配置工具";
            Phone = ResourceHelper.FindStringResource("Phone");
            E_mail = ResourceHelper.FindStringResource("E_mail");
        }

        #endregion
    }
}