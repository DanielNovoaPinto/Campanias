﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace serTI.Campania.Comunicacion.WCF.FuenteInformacion {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1))]
    public partial class StructuralObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1))]
    public partial class EntityObject : serTI.Campania.Comunicacion.WCF.FuenteInformacion.StructuralObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKey EntityKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKey EntityKey {
            get {
                return this.EntityKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyField, value) != true)) {
                    this.EntityKeyField = value;
                    this.RaisePropertyChanged("EntityKey");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FuenteInformacion", Namespace="http://schemas.datacontract.org/2004/07/serTI.Campania.Modelo.BaseDatos", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1))]
    public partial class FuenteInformacion : serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ClaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClaveCampaniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ClaveImportarClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaActualizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioActualizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioCreacionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Clave {
            get {
                return this.ClaveField;
            }
            set {
                if ((this.ClaveField.Equals(value) != true)) {
                    this.ClaveField = value;
                    this.RaisePropertyChanged("Clave");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClaveCampania {
            get {
                return this.ClaveCampaniaField;
            }
            set {
                if ((this.ClaveCampaniaField.Equals(value) != true)) {
                    this.ClaveCampaniaField = value;
                    this.RaisePropertyChanged("ClaveCampania");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ClaveImportarCliente {
            get {
                return this.ClaveImportarClienteField;
            }
            set {
                if ((this.ClaveImportarClienteField.Equals(value) != true)) {
                    this.ClaveImportarClienteField = value;
                    this.RaisePropertyChanged("ClaveImportarCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estatus {
            get {
                return this.EstatusField;
            }
            set {
                if ((this.EstatusField.Equals(value) != true)) {
                    this.EstatusField = value;
                    this.RaisePropertyChanged("Estatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaActualizacion {
            get {
                return this.FechaActualizacionField;
            }
            set {
                if ((this.FechaActualizacionField.Equals(value) != true)) {
                    this.FechaActualizacionField = value;
                    this.RaisePropertyChanged("FechaActualizacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaCreacion {
            get {
                return this.FechaCreacionField;
            }
            set {
                if ((this.FechaCreacionField.Equals(value) != true)) {
                    this.FechaCreacionField = value;
                    this.RaisePropertyChanged("FechaCreacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioActualizacion {
            get {
                return this.UsuarioActualizacionField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioActualizacionField, value) != true)) {
                    this.UsuarioActualizacionField = value;
                    this.RaisePropertyChanged("UsuarioActualizacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioCreacion {
            get {
                return this.UsuarioCreacionField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioCreacionField, value) != true)) {
                    this.UsuarioCreacionField = value;
                    this.RaisePropertyChanged("UsuarioCreacion");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FuenteInformacion", Namespace="http://schemas.datacontract.org/2004/07/serTI.Campania.Negocio.Reporte", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class FuenteInformacion1 : serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKey", Namespace="http://schemas.datacontract.org/2004/07/System.Data", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class EntityKey : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntityContainerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKeyMember> EntityKeyValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntitySetNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntityContainerName {
            get {
                return this.EntityContainerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityContainerNameField, value) != true)) {
                    this.EntityContainerNameField = value;
                    this.RaisePropertyChanged("EntityContainerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKeyMember> EntityKeyValues {
            get {
                return this.EntityKeyValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyValuesField, value) != true)) {
                    this.EntityKeyValuesField = value;
                    this.RaisePropertyChanged("EntityKeyValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntitySetName {
            get {
                return this.EntitySetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntitySetNameField, value) != true)) {
                    this.EntitySetNameField = value;
                    this.RaisePropertyChanged("EntitySetName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKeyMember", Namespace="http://schemas.datacontract.org/2004/07/System.Data")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.StructuralObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKey))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKeyMember>))]
    public partial class EntityKeyMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FuenteInformacion.IFuenteInformacion")]
    public interface IFuenteInformacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuenteInformacion/Insertar", ReplyAction="http://tempuri.org/IFuenteInformacion/InsertarResponse")]
        long Insertar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuenteInformacion/Actualizar", ReplyAction="http://tempuri.org/IFuenteInformacion/ActualizarResponse")]
        bool Actualizar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuenteInformacion/Eliminar", ReplyAction="http://tempuri.org/IFuenteInformacion/EliminarResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKey))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKeyMember>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKeyMember))]
        object Eliminar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuenteInformacion/Consultar", ReplyAction="http://tempuri.org/IFuenteInformacion/ConsultarResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKey))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKeyMember>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.FuenteInformacion.EntityKeyMember))]
        object Consultar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuenteInformacion/Listar", ReplyAction="http://tempuri.org/IFuenteInformacion/ListarResponse")]
        System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion> Listar(int Inicio, int Final);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFuenteInformacionChannel : serTI.Campania.Comunicacion.WCF.FuenteInformacion.IFuenteInformacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FuenteInformacionClient : System.ServiceModel.ClientBase<serTI.Campania.Comunicacion.WCF.FuenteInformacion.IFuenteInformacion>, serTI.Campania.Comunicacion.WCF.FuenteInformacion.IFuenteInformacion {
        
        public FuenteInformacionClient() {
        }
        
        public FuenteInformacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FuenteInformacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuenteInformacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuenteInformacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long Insertar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion) {
            return base.Channel.Insertar(fuenteinformacion);
        }
        
        public bool Actualizar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion) {
            return base.Channel.Actualizar(fuenteinformacion);
        }
        
        public object Eliminar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion) {
            return base.Channel.Eliminar(fuenteinformacion);
        }
        
        public object Consultar(serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion1 fuenteinformacion) {
            return base.Channel.Consultar(fuenteinformacion);
        }
        
        public System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.FuenteInformacion.FuenteInformacion> Listar(int Inicio, int Final) {
            return base.Channel.Listar(Inicio, Final);
        }
    }
}
