unit Entero;

interface
    var n : Integer;
    function CantidadDigitos() : Integer;
    procedure RegistrarN(nu: Integer);
    function Invertir(): Integer;
    function Ejercicio9(): Integer;
    function Ejercicio13(): Integer;

implementation

      procedure RegistrarN(nu: Integer);
      begin
        n:= nu;
      end;

      function Invertir(): Integer;
      var n1, nu, d: Integer;
      begin
        n1:=n;
        nu:=0;

        while n1>0 do
        begin
          d:= n1 mod 10;
          n1:=n1 div 10;

          nu:=nu*10+d;
        end;

        Result:=nu;
      end;

      function CantidadDigitos(): Integer;
      var c,n1: Integer;
      begin
           c:=0;
           n1:=n;
           while n1>0 do
           begin
             n1:=n1 div 10;
             c:=c+1;
           end;
           Result:=c;
      end;

      //De un n�mero natural, mostrar el digito del medio, si dicho numero tiene cantidad de d�gitos impares
      function Ejercicio9(): Integer;
      var n1, c, d,i,a,r: Integer;
      begin
        n1:=n;
        c:= CantidadDigitos();
        d:=0;

        if c mod 2 = 1 then
        begin
          i:= (c div 2) +1;
          a:=1;
          while a<=i do
          begin
             d:= n1 mod 10;
             n1:= n1 div 10;
             a:=a+1;
          end;
          r:=d;
          Result:=r;
        end
        else
        begin
          r:=-1;
        end;

        Result:=r;
      end;

      //Hacer un programa para mostrar el primer digito par
      function Ejercicio13(): Integer;
      var d, n1 : Integer;
      begin
        n1:=Invertir();
        d:=-1;


        while n1>0 do
        begin
          d:= n1 mod 10;
          n1:= n1 div 10;

          if d mod 2 =0  then
          begin
            n1:=0;
          end;
        end;

        Result:=d;
      end;
end.