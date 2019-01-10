namespace JenkinsBTDFDemoSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://JenkinsBTDFDemoSchemas.Person",@"PersonDetails")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PersonDetails"})]
    public sealed class Person : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://JenkinsBTDFDemoSchemas.Person"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://JenkinsBTDFDemoSchemas.Person"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PersonDetails"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Sno"" type=""xs:string"" />
              <xs:element name=""FName"" type=""xs:string"" />
              <xs:element name=""LName"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Person() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PersonDetails";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
