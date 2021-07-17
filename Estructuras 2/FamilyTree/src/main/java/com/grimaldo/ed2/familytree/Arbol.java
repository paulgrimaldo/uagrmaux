package com.grimaldo.ed2.familytree;
/**
 *
 * @author Ronaldo Rivero
 */
public class Arbol {
    
    private Nodo raiz;
    
    
    public Arbol(String padre) {
        raiz = new Nodo(padre);
    }
    
    public void casar(String varon, String mujer) {
        //buscar si existe el varon
        Nodo nodoVaron = buscarVaron(varon);
        if(nodoVaron == null){
            System.err.println("No existe el varon en el arbol");
            return;
        }        
        //buscar el nodo que tenga al varon        
        if(nodoVaron.getMujer() != null) {
            System.err.println("El varon ya esta casado con una mujer");
            return;
        }
        //para luego hacerle nodo.setMujer(mujer);
        nodoVaron.setMujer(mujer);
    }
    
    public void adicionarHijo(String pareja, String hijo) {
        //verificar que el nombre del hijo no exista
        Nodo nodoHijo = buscarVaron(hijo);
        if(nodoHijo != null) {
            System.err.println("El nombre del hijo ya existe en el arbol");
            return;
        }
        
        //separar el string de pareja en varon y mujer (splint('/'))
        String[] nombres = pareja.split("/");
        //buscar si existe el varon
        Nodo nodoVaron = buscarVaron(nombres[0]);
        if(nodoVaron == null){
            System.err.println("No existe el varon en el arbol");
            return;
        }   
        //buscar el nodo que tenga el varon y la mujer        
        if(nodoVaron.getMujer() == null) {
            System.err.println("El varon "+nombres[0]+" no esta casado");
            return;
        }
        if(!nodoVaron.getMujer().equals(nombres[1])) {
            System.err.println("La mujer "+nombres[1]+" no esta casada con "+nombres[0]);
            return;
        }
        //para luego insertar un hijo nodo.agregarHijo(new Nodo(hijo));
        nodoVaron.agregarHijo(new Nodo(hijo));
    }
    
    public String verArbol() {
        return verArbol(raiz, 1);
    }
    
    private String verArbol(Nodo p, int nivel) {        
        String s = "";
        if(p != null) {
            s = p.getVaron();
            if(p.getMujer() != null) {
                s = s + "/"+p.getMujer();
            }
            s = s + " { \n";
            for(int i = 1; i <= p.cantidadHijos(); i++) {
                s = s + separador(nivel) + verArbol(p.getHijo(i), nivel+1) + "\n";
            }
            s = s + separador(nivel-1) + "}";
        }
        return s;
    }
    
    private String separador(int nivel) {
        String s = "";
        for(int i = 0; i < nivel; i++) {
            s = s + "    ";
        }
        return s;
    }
    
    private Nodo buscarVaron(String varon) {
        return buscarVaron(raiz, varon);
    }
    
    /**
     * Busca en todo el arbol al varon, en caso no lo encuentre porque no existe
     * retorna null;
     * @param p
     * @param varon
     * @return 
     */
    private Nodo buscarVaron(Nodo p, String varon) {
        if(p == null)
            return null;
        
        if(p.esHoja()) {
            if(p.getVaron().equals(varon))
                return p;
            return null;
        }
        
        if(p.getVaron().equals(varon))
            return p;
        
        for(int i = 1; i <= p.cantidadHijos(); i++) {
            Nodo hijo = buscarVaron(p.getHijo(i), varon);
            if(hijo != null) {
                return hijo;
            }
        }
        return null;
    }
    
    public Nodo obtenerRaiz() {
        return raiz;
    }
}
