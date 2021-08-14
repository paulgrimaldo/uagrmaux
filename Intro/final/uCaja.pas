unit uCaja;
{$mode OBJFPC }
interface
  type 
    Caja=class 
      private 
        posx: Real;
        posy: Real;
        ancho: Real;
        alto: Real;
        
      public 
        constructor create;
        procedure dibujar;
        procedure SetPosx(xx: Real);
        procedure SetPosy(yy: Real);
        procedure SetAncho(aa: Real);
        procedure SetAlto(aa:Real);
        property GetPosX:Real read posx write SetPosx;
        property GetPosY:Real read posy write SetPosY;
        property GetAncho:Real read ancho write SetAncho;
        property GetAlto:Real read alto write SetAlto;
        function GetPosx1:Real;
    end;   
implementation
   
   constructor Caja.create;
   begin
     posx:=0;
     posy:=0;
     ancho:=0;
     alto:=0;
   end;
   
   procedure Caja.SetPosx(xx:Real);
   begin
     posx:=xx;
   end;
   function Caja.GetPosx1:Real;
   begin
     GetPosx1:=posx;
   end;
   procedure Caja.SetPosy(yy:Real);
   begin
     posy:=yy;
   end;
   
   procedure Caja.SetAncho(aa:Real);
   begin
     ancho:=aa;
   end;
   procedure Caja.SetAlto(aa:Real);
   begin
     alto:=aa;
   end;
  
    procedure Caja.dibujar;
    begin
      WriteLn('Estoy dibujando la caja');
    end;

end.
