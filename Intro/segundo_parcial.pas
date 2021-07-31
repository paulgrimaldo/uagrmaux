program segundo_parcial;
uses segundo_parcial_aux;
var n:Cardinal;
var s: String;
a:Integer;
begin

  WriteLn('Leer n ejercicio 1: ');
  ReadLn(n);
  WriteLn(ProductoDP(n));
  WriteLn('Leer s ejercicio 2: ');
  ReadLn(s);
  EliminarNoNumericos(s);
  WriteLn(s);
  WriteLn('Leer a ejercicio 3: ');
  ReadLn(a);
  WriteLn(NTermino(a));
end.