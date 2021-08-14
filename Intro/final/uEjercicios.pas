unit uEjercicios;
interface
  function SoloConsonantes(cad: String): String;
implementation
  
  function SoloConsonantes(cad: String): String;
  const c = 'qwrtypsdfghjklzxcvbnm';
  var i, l: Integer;
      nc: String;
  begin
     i:=1;
     l:=Length(cad);
     nc:='';
     while i<=l do
     begin
       if Pos(cad[i],c)>0 then
       begin
        nc:=nc+cad[i];
       end;
       i:=i+1;
     end;
     SoloConsonantes:=nc;
  end;
end.
