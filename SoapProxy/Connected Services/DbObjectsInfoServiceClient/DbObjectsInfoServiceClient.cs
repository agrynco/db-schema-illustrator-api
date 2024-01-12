﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapProxy.IDbObjectsInfoService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TableInfo", Namespace="http://tempuri.org/")]
    public partial class TableInfo : object
    {
        
        private SoapProxy.IDbObjectsInfoService.ColumnInfo[] ColumnsField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoapProxy.IDbObjectsInfoService.ColumnInfo[] Columns
        {
            get
            {
                return this.ColumnsField;
            }
            set
            {
                this.ColumnsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ColumnInfo", Namespace="http://tempuri.org/")]
    public partial class ColumnInfo : object
    {
        
        private bool IsPrimaryField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool IsPrimary
        {
            get
            {
                return this.IsPrimaryField;
            }
            set
            {
                this.IsPrimaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ForeignKeyInfo", Namespace="http://tempuri.org/")]
    public partial class ForeignKeyInfo : object
    {
        
        private string ConstraintNameField;
        
        private string ForeignKeyColumnNameField;
        
        private string ForeignKeyTableNameField;
        
        private string PrimaryKeyColumnNameField;
        
        private string PrimaryKeyTableNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ConstraintName
        {
            get
            {
                return this.ConstraintNameField;
            }
            set
            {
                this.ConstraintNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ForeignKeyColumnName
        {
            get
            {
                return this.ForeignKeyColumnNameField;
            }
            set
            {
                this.ForeignKeyColumnNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ForeignKeyTableName
        {
            get
            {
                return this.ForeignKeyTableNameField;
            }
            set
            {
                this.ForeignKeyTableNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PrimaryKeyColumnName
        {
            get
            {
                return this.PrimaryKeyColumnNameField;
            }
            set
            {
                this.PrimaryKeyColumnNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PrimaryKeyTableName
        {
            get
            {
                return this.PrimaryKeyTableNameField;
            }
            set
            {
                this.PrimaryKeyTableNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/")]
    public partial class ArrayOfString : object
    {
        
        private string stringField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string @string
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService")]
    public interface IDbObjectsInfoService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbObjectsInfoService/GetTables", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.GetTablesResponse> GetTablesAsync(SoapProxy.IDbObjectsInfoService.GetTablesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbObjectsInfoService/GetForeignKeys", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.GetForeignKeysResponse> GetForeignKeysAsync(SoapProxy.IDbObjectsInfoService.GetForeignKeysRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbObjectsInfoService/GetSchemas", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.ArrayOfString> GetSchemasAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTablesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTables", Namespace="http://tempuri.org/", Order=0)]
        public SoapProxy.IDbObjectsInfoService.GetTablesRequestBody Body;
        
        public GetTablesRequest()
        {
        }
        
        public GetTablesRequest(SoapProxy.IDbObjectsInfoService.GetTablesRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTablesRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string schemaName;
        
        public GetTablesRequestBody()
        {
        }
        
        public GetTablesRequestBody(string schemaName)
        {
            this.schemaName = schemaName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTablesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTablesResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapProxy.IDbObjectsInfoService.GetTablesResponseBody Body;
        
        public GetTablesResponse()
        {
        }
        
        public GetTablesResponse(SoapProxy.IDbObjectsInfoService.GetTablesResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTablesResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public SoapProxy.IDbObjectsInfoService.TableInfo[] GetTablesResult;
        
        public GetTablesResponseBody()
        {
        }
        
        public GetTablesResponseBody(SoapProxy.IDbObjectsInfoService.TableInfo[] GetTablesResult)
        {
            this.GetTablesResult = GetTablesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetForeignKeysRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetForeignKeys", Namespace="http://tempuri.org/", Order=0)]
        public SoapProxy.IDbObjectsInfoService.GetForeignKeysRequestBody Body;
        
        public GetForeignKeysRequest()
        {
        }
        
        public GetForeignKeysRequest(SoapProxy.IDbObjectsInfoService.GetForeignKeysRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetForeignKeysRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string schemaName;
        
        public GetForeignKeysRequestBody()
        {
        }
        
        public GetForeignKeysRequestBody(string schemaName)
        {
            this.schemaName = schemaName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetForeignKeysResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetForeignKeysResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapProxy.IDbObjectsInfoService.GetForeignKeysResponseBody Body;
        
        public GetForeignKeysResponse()
        {
        }
        
        public GetForeignKeysResponse(SoapProxy.IDbObjectsInfoService.GetForeignKeysResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetForeignKeysResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public SoapProxy.IDbObjectsInfoService.ForeignKeyInfo[] GetForeignKeysResult;
        
        public GetForeignKeysResponseBody()
        {
        }
        
        public GetForeignKeysResponseBody(SoapProxy.IDbObjectsInfoService.ForeignKeyInfo[] GetForeignKeysResult)
        {
            this.GetForeignKeysResult = GetForeignKeysResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IDbObjectsInfoServiceChannel : SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class DbObjectsInfoServiceClient : System.ServiceModel.ClientBase<SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService>, SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DbObjectsInfoServiceClient() : 
                base(DbObjectsInfoServiceClient.GetDefaultBinding(), DbObjectsInfoServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IDbObjectsInfoService_soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DbObjectsInfoServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(DbObjectsInfoServiceClient.GetBindingForEndpoint(endpointConfiguration), DbObjectsInfoServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DbObjectsInfoServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DbObjectsInfoServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DbObjectsInfoServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DbObjectsInfoServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DbObjectsInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.GetTablesResponse> SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService.GetTablesAsync(SoapProxy.IDbObjectsInfoService.GetTablesRequest request)
        {
            return base.Channel.GetTablesAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.GetTablesResponse> GetTablesAsync(string schemaName)
        {
            SoapProxy.IDbObjectsInfoService.GetTablesRequest inValue = new SoapProxy.IDbObjectsInfoService.GetTablesRequest();
            inValue.Body = new SoapProxy.IDbObjectsInfoService.GetTablesRequestBody();
            inValue.Body.schemaName = schemaName;
            return ((SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService)(this)).GetTablesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.GetForeignKeysResponse> SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService.GetForeignKeysAsync(SoapProxy.IDbObjectsInfoService.GetForeignKeysRequest request)
        {
            return base.Channel.GetForeignKeysAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.GetForeignKeysResponse> GetForeignKeysAsync(string schemaName)
        {
            SoapProxy.IDbObjectsInfoService.GetForeignKeysRequest inValue = new SoapProxy.IDbObjectsInfoService.GetForeignKeysRequest();
            inValue.Body = new SoapProxy.IDbObjectsInfoService.GetForeignKeysRequestBody();
            inValue.Body.schemaName = schemaName;
            return ((SoapProxy.IDbObjectsInfoService.IDbObjectsInfoService)(this)).GetForeignKeysAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<SoapProxy.IDbObjectsInfoService.ArrayOfString> GetSchemasAsync()
        {
            return base.Channel.GetSchemasAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDbObjectsInfoService_soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDbObjectsInfoService_soap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:5000/DbObjectsInfoService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return DbObjectsInfoServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IDbObjectsInfoService_soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return DbObjectsInfoServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IDbObjectsInfoService_soap);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IDbObjectsInfoService_soap,
        }
    }
}
