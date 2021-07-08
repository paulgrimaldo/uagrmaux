program demo_sumatorias; 

uses
  sumatorias;


var
  sf1, sf2, n: Integer;


begin
  sf1 := 0;
  sf2 := 0;
  WriteLn('Introducir n');
  ReadLn(n);
  sf1 := Ejercicio3(n);
  WriteLn('Resultado Ejercicio 3: ');
  WriteLn(sf1);
  sf2 := Ejercicio6(n);
  WriteLn('Resultado Ejercicio 6: ');
  WriteLn(sf2);
end.