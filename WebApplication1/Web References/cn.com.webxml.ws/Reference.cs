﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace WebApplication1.cn.com.webxml.ws {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WeatherWSSoap", Namespace="http://WebXml.com.cn/")]
    public partial class WeatherWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getRegionDatasetOperationCompleted;
        
        private System.Threading.SendOrPostCallback getRegionProvinceOperationCompleted;
        
        private System.Threading.SendOrPostCallback getRegionCountryOperationCompleted;
        
        private System.Threading.SendOrPostCallback getSupportCityDatasetOperationCompleted;
        
        private System.Threading.SendOrPostCallback getSupportCityStringOperationCompleted;
        
        private System.Threading.SendOrPostCallback getWeatherOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WeatherWS() {
            this.Url = global::WebApplication1.Properties.Settings.Default.WebApplication1_cn_com_webxml_ws_WeatherWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getRegionDatasetCompletedEventHandler getRegionDatasetCompleted;
        
        /// <remarks/>
        public event getRegionProvinceCompletedEventHandler getRegionProvinceCompleted;
        
        /// <remarks/>
        public event getRegionCountryCompletedEventHandler getRegionCountryCompleted;
        
        /// <remarks/>
        public event getSupportCityDatasetCompletedEventHandler getSupportCityDatasetCompleted;
        
        /// <remarks/>
        public event getSupportCityStringCompletedEventHandler getSupportCityStringCompleted;
        
        /// <remarks/>
        public event getWeatherCompletedEventHandler getWeatherCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getRegionDataset", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getRegionDataset() {
            object[] results = this.Invoke("getRegionDataset", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getRegionDatasetAsync() {
            this.getRegionDatasetAsync(null);
        }
        
        /// <remarks/>
        public void getRegionDatasetAsync(object userState) {
            if ((this.getRegionDatasetOperationCompleted == null)) {
                this.getRegionDatasetOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRegionDatasetOperationCompleted);
            }
            this.InvokeAsync("getRegionDataset", new object[0], this.getRegionDatasetOperationCompleted, userState);
        }
        
        private void OngetRegionDatasetOperationCompleted(object arg) {
            if ((this.getRegionDatasetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRegionDatasetCompleted(this, new getRegionDatasetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getRegionProvince", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getRegionProvince() {
            object[] results = this.Invoke("getRegionProvince", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getRegionProvinceAsync() {
            this.getRegionProvinceAsync(null);
        }
        
        /// <remarks/>
        public void getRegionProvinceAsync(object userState) {
            if ((this.getRegionProvinceOperationCompleted == null)) {
                this.getRegionProvinceOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRegionProvinceOperationCompleted);
            }
            this.InvokeAsync("getRegionProvince", new object[0], this.getRegionProvinceOperationCompleted, userState);
        }
        
        private void OngetRegionProvinceOperationCompleted(object arg) {
            if ((this.getRegionProvinceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRegionProvinceCompleted(this, new getRegionProvinceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getRegionCountry", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getRegionCountry() {
            object[] results = this.Invoke("getRegionCountry", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getRegionCountryAsync() {
            this.getRegionCountryAsync(null);
        }
        
        /// <remarks/>
        public void getRegionCountryAsync(object userState) {
            if ((this.getRegionCountryOperationCompleted == null)) {
                this.getRegionCountryOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRegionCountryOperationCompleted);
            }
            this.InvokeAsync("getRegionCountry", new object[0], this.getRegionCountryOperationCompleted, userState);
        }
        
        private void OngetRegionCountryOperationCompleted(object arg) {
            if ((this.getRegionCountryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRegionCountryCompleted(this, new getRegionCountryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getSupportCityDataset", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getSupportCityDataset(string theRegionCode) {
            object[] results = this.Invoke("getSupportCityDataset", new object[] {
                        theRegionCode});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getSupportCityDatasetAsync(string theRegionCode) {
            this.getSupportCityDatasetAsync(theRegionCode, null);
        }
        
        /// <remarks/>
        public void getSupportCityDatasetAsync(string theRegionCode, object userState) {
            if ((this.getSupportCityDatasetOperationCompleted == null)) {
                this.getSupportCityDatasetOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetSupportCityDatasetOperationCompleted);
            }
            this.InvokeAsync("getSupportCityDataset", new object[] {
                        theRegionCode}, this.getSupportCityDatasetOperationCompleted, userState);
        }
        
        private void OngetSupportCityDatasetOperationCompleted(object arg) {
            if ((this.getSupportCityDatasetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getSupportCityDatasetCompleted(this, new getSupportCityDatasetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getSupportCityString", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getSupportCityString(string theRegionCode) {
            object[] results = this.Invoke("getSupportCityString", new object[] {
                        theRegionCode});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getSupportCityStringAsync(string theRegionCode) {
            this.getSupportCityStringAsync(theRegionCode, null);
        }
        
        /// <remarks/>
        public void getSupportCityStringAsync(string theRegionCode, object userState) {
            if ((this.getSupportCityStringOperationCompleted == null)) {
                this.getSupportCityStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetSupportCityStringOperationCompleted);
            }
            this.InvokeAsync("getSupportCityString", new object[] {
                        theRegionCode}, this.getSupportCityStringOperationCompleted, userState);
        }
        
        private void OngetSupportCityStringOperationCompleted(object arg) {
            if ((this.getSupportCityStringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getSupportCityStringCompleted(this, new getSupportCityStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getWeather", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getWeather(string theCityCode, string theUserID) {
            object[] results = this.Invoke("getWeather", new object[] {
                        theCityCode,
                        theUserID});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getWeatherAsync(string theCityCode, string theUserID) {
            this.getWeatherAsync(theCityCode, theUserID, null);
        }
        
        /// <remarks/>
        public void getWeatherAsync(string theCityCode, string theUserID, object userState) {
            if ((this.getWeatherOperationCompleted == null)) {
                this.getWeatherOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetWeatherOperationCompleted);
            }
            this.InvokeAsync("getWeather", new object[] {
                        theCityCode,
                        theUserID}, this.getWeatherOperationCompleted, userState);
        }
        
        private void OngetWeatherOperationCompleted(object arg) {
            if ((this.getWeatherCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getWeatherCompleted(this, new getWeatherCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getRegionDatasetCompletedEventHandler(object sender, getRegionDatasetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRegionDatasetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRegionDatasetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getRegionProvinceCompletedEventHandler(object sender, getRegionProvinceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRegionProvinceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRegionProvinceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getRegionCountryCompletedEventHandler(object sender, getRegionCountryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRegionCountryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRegionCountryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getSupportCityDatasetCompletedEventHandler(object sender, getSupportCityDatasetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getSupportCityDatasetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getSupportCityDatasetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getSupportCityStringCompletedEventHandler(object sender, getSupportCityStringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getSupportCityStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getSupportCityStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    public delegate void getWeatherCompletedEventHandler(object sender, getWeatherCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1098.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getWeatherCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getWeatherCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591