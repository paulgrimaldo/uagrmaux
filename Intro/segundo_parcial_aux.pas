unit segundo_parcial_aux; 

interface

function EsPrimo(d: byte) : Boolean;
function ProductoDP(n: Cardinal) : Cardinal;
procedure EliminarNoNumericos(var x:String);
function NTermino(p:Integer):Integer;
implementation

function EsPrimo(d: byte) : Boolean;

const
  primos = [1, 2, 3, 5, 7];


var
  r: Boolean;


begin
  r := d in primos;
  EsPrimo := r;
end; 
function ProductoDP(n: Cardinal) : Cardinal;

var
  d: Integer;
  p: Cardinal;
  ep: Boolean;


begin
  p := 1;
  while (n > 0) do 
    begin
      d := n mod 10;
      n := n div 10;
      ep := EsPrimo(d);
      if (ep = true) then
        begin
          p := p * d;
        end ;
    end;
  ProductoDP := p;
end; 
procedure EliminarNoNumericos(var x:String);
var i,l:Integer;
const n = ['1','2', '3','4', '5', '6', '7', '8','9', '0'];
begin
  i:=1;
  l:=Length(x);
  while (i<=Length(x)) do
  begin
    if not((x[i]>='0')and(x[i]<='9')) then
    begin
      Delete(x,i,1);
      i:=i-1;
    end;
    i:=i+1;
  end;
end;
function NTermino(p:Integer):Integer;
var aux,a,b,c,b2: Integer;
begin
  a:=1;
  b:=3;
  b2:=3;
  c:=1;
  
  while c<=p do
  begin
    aux:=a;
    a:=b;
    b:=b-2;
    if b<1 then
    begin
      b2:=b2+2;
      b:=b2;
    end;
    c:=c+1;
  end;
  NTermino:=aux;
end;
  
end.