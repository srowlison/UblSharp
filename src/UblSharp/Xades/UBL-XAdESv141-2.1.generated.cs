// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp.Xades
{
    using XmlDigitalSignature;
    
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TimeStampValidationData", Namespace = "http://uri.etsi.org/01903/v1.4.1#")]
    [System.Xml.Serialization.XmlRootAttribute("TimeStampValidationData", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable=false)]
    public partial class ValidationDataType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=0)]
        public CertificateValuesType @__CertificateValues;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RevocationValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=1)]
        public RevocationValuesType @__RevocationValues;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("UR", DataType="anyURI")]
        public string @__UR;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CertificateValuesType CertificateValues
        {
            get
            {
                if (__CertificateValues == null) { __CertificateValues = new CertificateValuesType(); }
                return __CertificateValues;
            }
            set
            {
                __CertificateValues = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public RevocationValuesType RevocationValues
        {
            get
            {
                if (__RevocationValues == null) { __RevocationValues = new RevocationValuesType(); }
                return __RevocationValues;
            }
            set
            {
                __RevocationValues = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string UR
        {
            get
            {
                return __UR;
            }
            set
            {
                __UR = value;
            }
        }

    }
}
