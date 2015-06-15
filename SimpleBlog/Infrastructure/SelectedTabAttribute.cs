using System;
using System.Web.Mvc;

namespace SimpleBlog.Infrastructure
{
    /// <summary>
    /// This custom ActionAttribute should only work with Classes and Methods
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class SelectedTabAttribute : ActionFilterAttribute
	{
        public SelectedTabAttribute(string selectedTab)
        {
            _selectedTab = selectedTab;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.SelectedTab = _selectedTab;
        }

        /// <summary>
        /// Selected Tab string
        /// </summary>
        private string _selectedTab;
	}
}