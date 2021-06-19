program eliminarVocales;
var 
palabra, resultado : String;
tamano, posi : Integer;
vocales: Set of Char;
begin
  vocales:=['a','e','i', 'o', 'u'];
  ReadLn(palabra);
  tamano:=Length(palabra);
  
  for posi:=1 to tamano do
  begin  
    if not (palabra[posi] in vocales) then
    begin
      resultado:=resultado+palabra[posi];
    end;
  end;
  WriteLn(resultado);
end.
