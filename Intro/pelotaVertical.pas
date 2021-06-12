program pelotaVertical; 

uses
  crt;

var
  p, dir: Integer;
  //dir=1 Arriba, dir=2 Abajo

begin
  p := 7;
  //7 Limite Superior, 20 Limite Inferior
  dir := 2;
  repeat 
  
    //Limpio la pelota
    gotoXY(15, p);
    Write(' ');
    //Pinto la pelota
    gotoXY(15, p+1);
    Write('o');
    
    if dir = 1 then
      begin
        p := p - 1;
      end 
    else 
      begin
        p := p + 1;
      end;
    //Verifico los limites
    if p <= 7 then
      begin
        dir := 2;
      end ;
    if p >= 40 then
      begin
        dir := 1;
      end ;
    delay(100);
  until keypressed;
end.
