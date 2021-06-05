program progresionSimple;
var s,n : Integer;
begin

  s:=1;
  
  
  ReadLn(n);
 
  while (n>0) do
  begin
   WriteLn(s);
   s:=s+1;
   n:=n-1;
  end ;
end.
