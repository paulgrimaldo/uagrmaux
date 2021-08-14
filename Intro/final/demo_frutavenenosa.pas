program demo_frutavenenosa;
uses uFrutaVenenosa;
var f:FrutaVenenosa;
begin
  
  f:=FrutaVenenosa.create;
  f.SetPosx(1);
  f.SetPosy(2);
  f.SetPuntos('1,2,1');
  f.SetFigura('Pera');
  f.SetColor('Verde');
  WriteLn(f.ToStr);
  
  f.Mostrar;
  f.Borrar;
end.
