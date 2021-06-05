program de0HastaM;
var
  s,n,m: Integer;
  
begin
  s:=0;
  ReadLn(n);
  
  ReadLn(m);
  while (n>0) do
  begin
    WriteLn(s);
    
    s:=s+1;
    if(s>m) then
    begin
      s:=0;
    end;
    n:=n-1;
  end
end.
