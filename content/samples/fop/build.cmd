mkdir target
copy ..\..\lib\*.* target\

Csc.exe /warn:0 /reference:..\..\lib\jni4net.n-0.8.4.0.dll /out:target\fop.exe /target:exe csharp\javax\xml\transform\Result.generated.cs csharp\javax\xml\transform\sax\SAXResult.generated.cs csharp\javax\xml\transform\Source.generated.cs csharp\javax\xml\transform\stream\StreamSource.generated.cs csharp\javax\xml\transform\Transformer.generated.cs csharp\javax\xml\transform\TransformerException.generated.cs csharp\javax\xml\transform\TransformerFactory.generated.cs csharp\java\io\BufferedOutputStream.generated.cs csharp\java\io\FileOutputStream.generated.cs csharp\org\apache\fop\apps\Fop.generated.cs csharp\org\apache\fop\apps\FopFactory.generated.cs csharp\org\apache\fop\apps\MimeConstants.generated.cs csharp\Program.cs