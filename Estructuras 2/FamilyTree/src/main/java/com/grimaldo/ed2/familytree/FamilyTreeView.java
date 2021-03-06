/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.grimaldo.ed2.familytree;

import com.google.gson.Gson;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFileChooser;
import javax.swing.tree.DefaultMutableTreeNode;
import javax.swing.tree.DefaultTreeModel;

/**
 *
 * @author Paul
 */
public class FamilyTreeView extends javax.swing.JFrame {

    private Arbol arbol;

    /**
     * Creates new form FamilyTreeView
     */
    public FamilyTreeView() {
        initComponents();
        /*arbol = new Arbol("Adan");
        arbol.casar("Adan", "Eva");
        llenarTreeView();
         */
        treeView.setModel(null);
    }

    private void llenarTreeView() {
        Nodo raiz = arbol.obtenerRaiz();

        DefaultMutableTreeNode raizGrafico = new DefaultMutableTreeNode(raiz.visualizar());
        llenarArbolGrafico(raiz, raizGrafico);

        DefaultTreeModel model = new DefaultTreeModel(raizGrafico);
        treeView.setModel(model);
    }

    private void llenarArbolGrafico(Nodo t, DefaultMutableTreeNode tNodo) {
        if (t == null) {
            return;
        } else {
            for (int i = 1; 1 <= t.cantidadHijos(); i++) {
                Nodo h = t.getHijo(i);

                if (h == null) {
                    break;
                }

                DefaultMutableTreeNode child = new DefaultMutableTreeNode(h.visualizar());
                tNodo.add(child);
                llenarArbolGrafico(h, child);
            }
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        treeView = new javax.swing.JTree();
        txtVaron = new javax.swing.JTextField();
        txtMujer = new javax.swing.JTextField();
        btnCasar = new javax.swing.JButton();
        txtHijo = new javax.swing.JTextField();
        btnAddHijo = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        jMenuItem2 = new javax.swing.JMenuItem();
        jMenuItem1 = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jScrollPane1.setViewportView(treeView);

        txtVaron.setText("Adan");

        txtMujer.setText("Eva");

        btnCasar.setText("Casar");
        btnCasar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCasarActionPerformed(evt);
            }
        });

        txtHijo.setText("Pedro");

        btnAddHijo.setText("Agregar hijo");
        btnAddHijo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAddHijoActionPerformed(evt);
            }
        });

        jMenu1.setText("Archivo");

        jMenuItem2.setText("Guardar");
        jMenuItem2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem2ActionPerformed(evt);
            }
        });
        jMenu1.add(jMenuItem2);

        jMenuItem1.setText("Leer");
        jMenuItem1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem1ActionPerformed(evt);
            }
        });
        jMenu1.add(jMenuItem1);

        jMenuBar1.add(jMenu1);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(157, 157, 157)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 535, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtMujer, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtVaron, javax.swing.GroupLayout.PREFERRED_SIZE, 103, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnCasar)
                        .addGap(140, 140, 140)
                        .addComponent(txtHijo, javax.swing.GroupLayout.PREFERRED_SIZE, 69, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnAddHijo)))
                .addContainerGap(158, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(txtVaron, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(txtMujer, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(21, 21, 21)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btnCasar)
                            .addComponent(txtHijo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(btnAddHijo))))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 54, Short.MAX_VALUE)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 223, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(123, 123, 123))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jMenuItem2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem2ActionPerformed
        // TODO add your handling code here:
        JFileChooser chooser = new JFileChooser();
        int opcion = chooser.showSaveDialog(this);

        //opcion es 0 si le da aceptar en la ventana
        if (opcion == JFileChooser.APPROVE_OPTION) {
            File archivoAGuardar = chooser.getSelectedFile();
            String ruta = archivoAGuardar.getAbsolutePath();

            Gson gson = new Gson();
            String arbolSerializado = gson.toJson(arbol);

            try {
                FileWriter writter = new FileWriter(ruta);
                writter.write(arbolSerializado);

                writter.flush();
                writter.close();
            } catch (IOException ex) {
                Logger.getLogger(FamilyTreeView.class.getName()).log(Level.SEVERE, null, ex);
            }

        }
    }//GEN-LAST:event_jMenuItem2ActionPerformed

    private void btnCasarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCasarActionPerformed
        // TODO add your handling code here:

        if (arbol == null) {
            String varon = txtVaron.getText();
            String mujer = txtMujer.getText();

            if (!varon.equals("") && !mujer.equals("")) {
                arbol = new Arbol(varon);
                arbol.casar(varon, mujer);
            }
        } else {
            String varon = txtVaron.getText();
            String mujer = txtMujer.getText();

            if (!varon.equals("") && !mujer.equals("")) {
                arbol.casar(varon, mujer);
            }
        }

        llenarTreeView();
    }//GEN-LAST:event_btnCasarActionPerformed

    private void btnAddHijoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAddHijoActionPerformed
        // TODO add your handling code here:

        if (arbol == null) {
            return;
        } else {
            String hijo = txtHijo.getText();
            String padre = txtVaron.getText();
            String madre = txtMujer.getText();

            String pareja = padre + "/" + madre;
            arbol.adicionarHijo(pareja, hijo);
            llenarTreeView();
        }
    }//GEN-LAST:event_btnAddHijoActionPerformed

    private void jMenuItem1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem1ActionPerformed
        // TODO add your handling code here:
        JFileChooser chooser = new JFileChooser();
        int opcion = chooser.showOpenDialog(this);

        //opcion = 0 es ok 
        if (opcion == JFileChooser.APPROVE_OPTION) {
            File archivoALeer = chooser.getSelectedFile();            
            String data = "";
            try {
                Scanner reader = new Scanner(archivoALeer);
                while (reader.hasNextLine()) {

                    data = data + reader.nextLine();
                }
                
                Gson gson = new Gson();
                arbol = gson.fromJson(data, Arbol.class);
                
                llenarTreeView();
            } catch (FileNotFoundException ex) {
                Logger.getLogger(FamilyTreeView.class.getName()).log(Level.SEVERE, null, ex);
            }

        }
    }//GEN-LAST:event_jMenuItem1ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(FamilyTreeView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FamilyTreeView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FamilyTreeView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FamilyTreeView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FamilyTreeView().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAddHijo;
    private javax.swing.JButton btnCasar;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JMenuItem jMenuItem1;
    private javax.swing.JMenuItem jMenuItem2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTree treeView;
    private javax.swing.JTextField txtHijo;
    private javax.swing.JTextField txtMujer;
    private javax.swing.JTextField txtVaron;
    // End of variables declaration//GEN-END:variables
}
