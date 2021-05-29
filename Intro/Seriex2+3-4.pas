program ejercicio4;
var 
  s, c, n : Integer;
  b2 , b3 : Boolean;
  
begin
  s:=2;
  b2:= true;
  b3:= true;
 
  ReadLn(n);
  
  for c:=1 to n do
  begin
    WriteLn(s);
    
    if (b2 = true) then
    begin
      s:=s*2;
      b2:=false;
      b3:=true;
    end
    else 
    begin
      if(b3= true) then
      begin
        s:=s+3;
        b3:=false;
      end
      else
      begin
        s:=s-4;
        b2:=true;
      end
    end
  end 
  
end.
