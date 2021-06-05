program serieFibbonacci;
var
  s, a,b, c, n : Integer;
  

begin
  s:=0;
  a:=-1;
  b:=1;
  c:=1;
  
  ReadLn(n);
  while (c<=n) do
  begin
    s:= a + b;
    a:=b;
    b:=s;
    c:=c+1;
    WriteLn(s);
  end
end.