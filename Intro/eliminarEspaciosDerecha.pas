program eliminarEspaciosDerecha;
var 
palabra, resultado: String;
tamano, posi : Integer;
encontrado: Boolean;
begin
  ReadLn(palabra);
  tamano:=Length(palabra);
  posi:=tamano;
  encontrado:=False;
  
  While (posi>=1) And Not encontrado do
  begin
    if palabra[posi]<> ' ' then
    begin
      encontrado:=True;
    end
    else
    begin
      posi:=posi-1;
    end;
  end;
  resultado:=Copy(palabra,1,posi);
  WriteLn(resultado);
end.
