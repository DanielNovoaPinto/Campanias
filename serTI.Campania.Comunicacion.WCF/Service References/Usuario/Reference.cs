﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace serTI.Campania.Comunicacion.WCF.Usuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1))]
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1))]
    public partial class EntityObject : serTI.Campania.Comunicacion.WCF.Usuario.StructuralObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private serTI.Campania.Comunicacion.WCF.Usuario.EntityKey EntityKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public serTI.Campania.Comunicacion.WCF.Usuario.EntityKey EntityKey {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/serTI.Campania.Modelo.BaseDatos", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1))]
    public partial class Usuario : serTI.Campania.Comunicacion.WCF.Usuario.EntityObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClavePerfilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaActualizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usuario1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioActualizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioCreacionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Clave {
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
        public int ClavePerfil {
            get {
                return this.ClavePerfilField;
            }
            set {
                if ((this.ClavePerfilField.Equals(value) != true)) {
                    this.ClavePerfilField = value;
                    this.RaisePropertyChanged("ClavePerfil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasenia {
            get {
                return this.ContraseniaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseniaField, value) != true)) {
                    this.ContraseniaField = value;
                    this.RaisePropertyChanged("Contrasenia");
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
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usuario1 {
            get {
                return this.Usuario1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Usuario1Field, value) != true)) {
                    this.Usuario1Field = value;
                    this.RaisePropertyChanged("Usuario1");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/serTI.Campania.Negocio.Administracion", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Usuario1 : serTI.Campania.Comunicacion.WCF.Usuario.Usuario {
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
        private System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.EntityKeyMember> EntityKeyValuesField;
        
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
        public System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.EntityKeyMember> EntityKeyValues {
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.Usuario>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.StructuralObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityKey))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.EntityKeyMember>))]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Usuario.IUsuario")]
    public interface IUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Insertar", ReplyAction="http://tempuri.org/IUsuario/InsertarResponse")]
        long Insertar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Actualizar", ReplyAction="http://tempuri.org/IUsuario/ActualizarResponse")]
        bool Actualizar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Eliminar", ReplyAction="http://tempuri.org/IUsuario/EliminarResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.Usuario>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityKey))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.EntityKeyMember>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityKeyMember))]
        object Eliminar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Consultar", ReplyAction="http://tempuri.org/IUsuario/ConsultarResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.Usuario>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityKey))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.EntityKeyMember>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(serTI.Campania.Comunicacion.WCF.Usuario.EntityKeyMember))]
        object Consultar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/ValidarUsuario", ReplyAction="http://tempuri.org/IUsuario/ValidarUsuarioResponse")]
        short ValidarUsuario(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Listar", ReplyAction="http://tempuri.org/IUsuario/ListarResponse")]
        System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.Usuario> Listar(int Inicio, int Final);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioChannel : serTI.Campania.Comunicacion.WCF.Usuario.IUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioClient : System.ServiceModel.ClientBase<serTI.Campania.Comunicacion.WCF.Usuario.IUsuario>, serTI.Campania.Comunicacion.WCF.Usuario.IUsuario {
        
        public UsuarioClient() {
        }
        
        public UsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long Insertar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario) {
            return base.Channel.Insertar(usuario);
        }
        
        public bool Actualizar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario) {
            return base.Channel.Actualizar(usuario);
        }
        
        public object Eliminar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario) {
            return base.Channel.Eliminar(usuario);
        }
        
        public object Consultar(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario) {
            return base.Channel.Consultar(usuario);
        }
        
        public short ValidarUsuario(serTI.Campania.Comunicacion.WCF.Usuario.Usuario1 usuario) {
            return base.Channel.ValidarUsuario(usuario);
        }
        
        public System.Collections.Generic.List<serTI.Campania.Comunicacion.WCF.Usuario.Usuario> Listar(int Inicio, int Final) {
            return base.Channel.Listar(Inicio, Final);
        }
    }
}
