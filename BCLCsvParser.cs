using Microsoft.VisualBasic.FileIO;


var csv = """
  1;2;3
  4;5;6
  """;

using var strrd = new StringReader(csv);
var parser = new TextFieldParser(strrd);
parser.Delimiters = new[] { ";" };
var i = 0;
while (!parser.EndOfData)
{
  
  var fields = parser.ReadFields();
  WriteLine($"Line #{++i}");
  foreach(var field in fields)
  {
    WriteLine($"\t{field}");
  }
}
