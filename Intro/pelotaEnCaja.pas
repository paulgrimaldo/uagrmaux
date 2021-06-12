program pelotaEnCaja; 

uses
  crt;


var
  px, py, v, h, vel: Integer;
  key: Char;


begin
  px := 15;
  py := 35;
  v := 1;
  h := 1;
  vel := 100;
  repeat 
    clrscr();
    gotoXY(px, py);
    Write('o');
    if keyPressed() then
      begin
        key := readKey();
        if key = 'h' then
          begin
            vel := vel - 10;
          end ;
        if key = 'l' then
          begin
            vel := vel + 10;
          end ;
      end ;
    if (v = 1) and (h = 1) then
      begin
        px := px + 1;
        py := py - 1;
      end ;
    if (v = 2) and (h = 1) then
      begin
        px := px + 1;
        py := py + 1;
      end ;
    if (v = 2) and (h = 2) then
      begin
        px := px - 1;
        py := py + 1;
      end ;
    if (v = 1) and (h = 2) then
      begin
        px := px - 1;
        py := py - 1;
      end ;
    if py <= 7 then
      begin
        v := 2;
      end ;
    if py >= 50 then
      begin
        v := 1;
      end ;
    if px >= 60 then
      begin
        h := 2;
      end ;
    if px <= 2 then
      begin
        h := 1;
      end ;
    delay(vel);
  until key = 'f';
end.