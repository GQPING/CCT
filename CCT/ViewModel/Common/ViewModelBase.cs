﻿using Prism.Mvvm;

namespace CCT.ViewModel
{
    /// <summary>
    /// ViewModel基类
    /// </summary>
    public class ViewModelBase : BindableBase
    {

        #region 私有域

        private string title = "CCT通用配置工具";//窗口标题
       
        private string status="Ready";//状态

        #endregion

        #region 属性

        /// <summary>
        /// 窗口标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        /// <summary>
        /// 状态字符串
        /// </summary>
        public string Status
        {
            get { return status; }
            set { SetProperty(ref status, value); }
        }

        #endregion
    }
}