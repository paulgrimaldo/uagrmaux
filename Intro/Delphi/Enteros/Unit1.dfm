object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 486
  ClientWidth = 877
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object TxtNum: TEdit
    Left = 192
    Top = 144
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Numero'
  end
  object TxtResult: TEdit
    Left = 192
    Top = 240
    Width = 121
    Height = 21
    TabOrder = 1
    Text = 'Resultado'
  end
  object MainMenu1: TMainMenu
    Left = 8
    Top = 8
    object Ejercicios1: TMenuItem
      Caption = 'Ejercicios'
      object Eliminarprimeryultimodigito1: TMenuItem
        Caption = 'Eliminar primer y ultimo digito'
        OnClick = Eliminarprimeryultimodigito1Click
      end
      object Mayorposicionesimpares1: TMenuItem
        Caption = 'Mayor posiciones impares'
        OnClick = Mayorposicionesimpares1Click
      end
    end
  end
end
