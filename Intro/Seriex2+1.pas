program ejercicio3;
var 
  s, c, n :Integer;
  b2: Boolean;
begin
  
  s:=1;
  c:=1;
  b2:=true;
  
  ReadLn(n);
  
  while (c<=n) do
  begin
    WriteLn(s);
    
    if(b2=true) then
    begin
      s:=s*2;
      b2:=false;
    end 
    else
    begin
      s:=s+1;
      b2:=true;
    end;
    
    c:=c+1;
  end;
   
end.
