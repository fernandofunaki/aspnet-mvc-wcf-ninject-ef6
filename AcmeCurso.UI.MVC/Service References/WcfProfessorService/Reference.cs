﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcmeCurso.UI.MVC.WcfProfessorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfProfessorService.IProfessorService")]
    public interface IProfessorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Add", ReplyAction="http://tempuri.org/IProfessorService/AddResponse")]
        void Add(AcmeCurso.Domain.Professor item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Add", ReplyAction="http://tempuri.org/IProfessorService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(AcmeCurso.Domain.Professor item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Delete", ReplyAction="http://tempuri.org/IProfessorService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Delete", ReplyAction="http://tempuri.org/IProfessorService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Update", ReplyAction="http://tempuri.org/IProfessorService/UpdateResponse")]
        void Update(AcmeCurso.Domain.Professor item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/Update", ReplyAction="http://tempuri.org/IProfessorService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(AcmeCurso.Domain.Professor item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetById", ReplyAction="http://tempuri.org/IProfessorService/GetByIdResponse")]
        AcmeCurso.Domain.Professor GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetById", ReplyAction="http://tempuri.org/IProfessorService/GetByIdResponse")]
        System.Threading.Tasks.Task<AcmeCurso.Domain.Professor> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAll", ReplyAction="http://tempuri.org/IProfessorService/GetAllResponse")]
        AcmeCurso.Domain.Professor[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorService/GetAll", ReplyAction="http://tempuri.org/IProfessorService/GetAllResponse")]
        System.Threading.Tasks.Task<AcmeCurso.Domain.Professor[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProfessorServiceChannel : AcmeCurso.UI.MVC.WcfProfessorService.IProfessorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProfessorServiceClient : System.ServiceModel.ClientBase<AcmeCurso.UI.MVC.WcfProfessorService.IProfessorService>, AcmeCurso.UI.MVC.WcfProfessorService.IProfessorService {
        
        public ProfessorServiceClient() {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Add(AcmeCurso.Domain.Professor item) {
            base.Channel.Add(item);
        }
        
        public System.Threading.Tasks.Task AddAsync(AcmeCurso.Domain.Professor item) {
            return base.Channel.AddAsync(item);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void Update(AcmeCurso.Domain.Professor item) {
            base.Channel.Update(item);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(AcmeCurso.Domain.Professor item) {
            return base.Channel.UpdateAsync(item);
        }
        
        public AcmeCurso.Domain.Professor GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<AcmeCurso.Domain.Professor> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public AcmeCurso.Domain.Professor[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<AcmeCurso.Domain.Professor[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}