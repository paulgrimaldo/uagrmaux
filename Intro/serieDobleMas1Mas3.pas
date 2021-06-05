program serieDobleMas1Mas3;
var 
  s1, s2, n: Integer;
  sw: Boolean;

begin
  s1:=0;
  s2:=-3;
  sw:= true;
  
  ReadLn(n);
  
  while (n>0) do 
  begin 
    if (sw=true) then
    begin
      s1:=s1+1;
      WriteLn(s1);
      sw:=false;
    end
    else
    begin
      s2:=s2+3;
      WriteLn(s2);
      sw:=true;
    end;
    n:=n-1;
  end;
end.
