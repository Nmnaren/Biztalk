namespace JenkinsBTDFDemo.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"JenkinsBTDFDemoSchemas.Person", typeof(global::JenkinsBTDFDemoSchemas.Person))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"JenkinsBTDFDemoSchemas.Client", typeof(global::JenkinsBTDFDemoSchemas.Client))]
    public sealed class PersonToClient : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://JenkinsBTDFDemoSchemas.Client"" xmlns:s0=""http://JenkinsBTDFDemoSchemas.Person"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PersonDetails"" />
  </xsl:template>
  <xsl:template match=""/s0:PersonDetails"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Person/FName/text()) , string(Person/LName/text()))"" />
    <ns0:ClientDetails>
      <Client>
        <Id>
          <xsl:value-of select=""Person/Sno/text()"" />
        </Id>
        <FullName>
          <xsl:value-of select=""$var:v1"" />
        </FullName>
        <City>
          <xsl:value-of select=""Person/City/text()"" />
        </City>
      </Client>
    </ns0:ClientDetails>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"JenkinsBTDFDemoSchemas.Person";
        
        private const global::JenkinsBTDFDemoSchemas.Person _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"JenkinsBTDFDemoSchemas.Client";
        
        private const global::JenkinsBTDFDemoSchemas.Client _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"JenkinsBTDFDemoSchemas.Person";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"JenkinsBTDFDemoSchemas.Client";
                return _TrgSchemas;
            }
        }
    }
}
