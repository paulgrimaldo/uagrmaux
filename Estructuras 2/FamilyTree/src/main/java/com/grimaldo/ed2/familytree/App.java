package com.grimaldo.ed2.familytree;

import com.google.gson.Gson;

public class App {

  public static void main(String[] args) {
  
        Arbol arbol = new Arbol("Adan");
        arbol.casar("Adan", "Eva");
        arbol.adicionarHijo("Adan/Eva", "Cain");
        arbol.adicionarHijo("Adan/Eva", "Abel");
        
        arbol.casar("Cain", "Ana");
        arbol.casar("Abel", "Ana");
        
        arbol.adicionarHijo("Cain/Ana", "Ronaldo");
        arbol.casar("Ronaldo", "Carla");
        arbol.adicionarHijo("Ronaldo/Carla", "Thiago");
        arbol.adicionarHijo("Ronaldo/Carla", "Marcelo");
        arbol.adicionarHijo("Ronaldo/Carla", "Roberto");
        
        ///System.out.println(arbol.verArbol());
        
        Gson gson = new Gson();
        String texto = gson.toJson(arbol);
        System.out.println(texto);
  }

}
