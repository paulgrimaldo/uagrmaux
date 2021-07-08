program demo_cadenas;
var 
  cadena: String;
  ce, cp,cl, cn : Integer;
  vocalONo: Boolean;
  caracter : Char;
uses cadena;
begin

  ReadLn(cadena);
  ReadLn(caracter);
  WriteLn('Es vocal: ');
  vocalONo:= EsVocal(caracter);
  WriteLn(vocalONo);
  WriteLn('Cantidad de espacios: ');
  ce:= CantidadEspacios(cadena);
  WriteLn(ce);
  WriteLn('Cantidad de palabras: ');
  cp:=CantidadPalabras(cadena);
  WriteLn(cp);
  WriteLn('Cantidad de letras: ');
  cl:=CantidadLetras(cadena);
  WriteLn(cl);
  WriteLn('Cantidad de numeros: ');
  cn:=CantidadNumeros(cadena);
  WriteLn(cn);
end.
