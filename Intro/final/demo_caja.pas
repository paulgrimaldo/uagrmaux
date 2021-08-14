program demo_caja;
uses uCaja;
var c:Caja;
begin
  
  c:=Caja.create;
  WriteLn('C crea la caja');
  c.SetPosx(2);
  WriteLn('C modifica su posx con un valor'); 
  
  c.Dibujar();
  WriteLn('C se dibuja');
end.
