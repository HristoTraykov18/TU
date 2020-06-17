
package CourseAppGUI;
import javacourseapp.Matrix;
import javacourseapp.ExtendedMatrix;

public class Main extends javax.swing.JFrame {
    Matrix matrixOne = null; // Matrix A
    Matrix matrixTwo = null; // Matrix B
    
    public Main() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        rowsAndColsSet = new javax.swing.JFrame();
        buttonGenerateMatrixOne = new javax.swing.JButton();
        buttonGenerateMatrixTwo = new javax.swing.JButton();
        matrixOneContainerScrollPane = new javax.swing.JScrollPane();
        matrixOneContainer = new javax.swing.JTextArea();
        matrixTwoContainerScrollPane = new javax.swing.JScrollPane();
        matrixTwoContainer = new javax.swing.JTextArea();
        buttonGetFirstDeterminant = new javax.swing.JButton();
        buttonGetSecondDeterminant = new javax.swing.JButton();
        buttonReverseRowsMatrixOne = new javax.swing.JButton();
        buttonReverseRowsMatrixTwo = new javax.swing.JButton();
        buttonReverseColumnsMatrixOne = new javax.swing.JButton();
        buttonReverseColumnsMatrixTwo = new javax.swing.JButton();
        resultScrollPane = new javax.swing.JScrollPane();
        resultArea = new javax.swing.JTextArea();
        sliderMatrixOneRows = new javax.swing.JSlider();
        sliderMatrixOneColumns = new javax.swing.JSlider();
        sliderMatrixTwoRows = new javax.swing.JSlider();
        sliderMatrixTwoColumns = new javax.swing.JSlider();
        buttonMultiplyMatrices = new javax.swing.JButton();
        buttonDivideMatrices = new javax.swing.JButton();
        buttonSubtractMatrices = new javax.swing.JButton();
        buttonAddMatrices = new javax.swing.JButton();

        rowsAndColsSet.setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        rowsAndColsSet.setTitle("Matrix row and column select");
        rowsAndColsSet.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        rowsAndColsSet.setPreferredSize(new java.awt.Dimension(300, 200));
        rowsAndColsSet.setResizable(false);
        rowsAndColsSet.setSize(new java.awt.Dimension(300, 200));

        javax.swing.GroupLayout rowsAndColsSetLayout = new javax.swing.GroupLayout(rowsAndColsSet.getContentPane());
        rowsAndColsSet.getContentPane().setLayout(rowsAndColsSetLayout);
        rowsAndColsSetLayout.setHorizontalGroup(
            rowsAndColsSetLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 300, Short.MAX_VALUE)
        );
        rowsAndColsSetLayout.setVerticalGroup(
            rowsAndColsSetLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 200, Short.MAX_VALUE)
        );

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Java course application");
        setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        setLocation(new java.awt.Point(600, 300));
        setMinimumSize(new java.awt.Dimension(10, 0));
        setName("Course app frame"); // NOI18N
        setResizable(false);
        setSize(new java.awt.Dimension(700, 400));

        buttonGenerateMatrixOne.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonGenerateMatrixOne.setText("Generate matrix");
        buttonGenerateMatrixOne.setToolTipText("");
        buttonGenerateMatrixOne.setInheritsPopupMenu(true);
        buttonGenerateMatrixOne.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGenerateMatrixOne_MouseClick(evt);
            }
        });

        buttonGenerateMatrixTwo.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonGenerateMatrixTwo.setText("Generate matrix");
        buttonGenerateMatrixTwo.setToolTipText("");
        buttonGenerateMatrixTwo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGenerateMatrixTwo_MouseClick(evt);
            }
        });

        matrixOneContainer.setEditable(false);
        matrixOneContainer.setBackground(new java.awt.Color(255, 255, 255));
        matrixOneContainer.setColumns(20);
        matrixOneContainer.setFont(new java.awt.Font("Dialog", 0, 14)); // NOI18N
        matrixOneContainer.setForeground(new java.awt.Color(0, 0, 0));
        matrixOneContainer.setRows(5);
        matrixOneContainer.setTabSize(4);
        matrixOneContainer.setToolTipText("When generated, matrix A will be displayed");
        matrixOneContainer.setCaretColor(new java.awt.Color(255, 255, 255));
        matrixOneContainer.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        matrixOneContainer.setRequestFocusEnabled(false);
        matrixOneContainerScrollPane.setViewportView(matrixOneContainer);
        matrixOneContainer.getAccessibleContext().setAccessibleName("matrixOneContainer");
        matrixOneContainer.getAccessibleContext().setAccessibleDescription("");
        matrixOneContainer.getAccessibleContext().setAccessibleParent(null);

        matrixTwoContainer.setEditable(false);
        matrixTwoContainer.setBackground(new java.awt.Color(255, 255, 255));
        matrixTwoContainer.setColumns(20);
        matrixTwoContainer.setFont(new java.awt.Font("Dialog", 0, 14)); // NOI18N
        matrixTwoContainer.setForeground(new java.awt.Color(0, 0, 0));
        matrixTwoContainer.setRows(5);
        matrixTwoContainer.setTabSize(4);
        matrixTwoContainer.setToolTipText("When generated, matrix B will be displayed");
        matrixTwoContainer.setCaretColor(new java.awt.Color(255, 255, 255));
        matrixTwoContainer.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        matrixTwoContainer.setRequestFocusEnabled(false);
        matrixTwoContainerScrollPane.setViewportView(matrixTwoContainer);

        buttonGetFirstDeterminant.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonGetFirstDeterminant.setText("Get determinant");
        buttonGetFirstDeterminant.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGetFirstDeterminant_MouseClick(evt);
            }
        });

        buttonGetSecondDeterminant.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonGetSecondDeterminant.setText("Get determinant");
        buttonGetSecondDeterminant.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGetSecondDeterminant_MouseClick(evt);
            }
        });

        buttonReverseRowsMatrixOne.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonReverseRowsMatrixOne.setText("Reverse rows");
        buttonReverseRowsMatrixOne.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonReverseRowsMatrixOne_MouseClick(evt);
            }
        });

        buttonReverseRowsMatrixTwo.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonReverseRowsMatrixTwo.setText("Reverse rows");
        buttonReverseRowsMatrixTwo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonReverseRowsMatrixTwo_MouseClick(evt);
            }
        });

        buttonReverseColumnsMatrixOne.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonReverseColumnsMatrixOne.setText("Reverse columns");
        buttonReverseColumnsMatrixOne.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonReverseColumnsMatrixOne_MouseClick(evt);
            }
        });

        buttonReverseColumnsMatrixTwo.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonReverseColumnsMatrixTwo.setText("Reverse columns");
        buttonReverseColumnsMatrixTwo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonReverseColumnsMatrixTwo_MouseClick(evt);
            }
        });

        resultArea.setEditable(false);
        resultArea.setBackground(new java.awt.Color(255, 255, 255));
        resultArea.setColumns(20);
        resultArea.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        resultArea.setForeground(new java.awt.Color(0, 0, 0));
        resultArea.setRows(5);
        resultArea.setTabSize(4);
        resultArea.setToolTipText("");
        resultArea.setCaretColor(new java.awt.Color(255, 255, 255));
        resultArea.setRequestFocusEnabled(false);
        resultScrollPane.setViewportView(resultArea);

        sliderMatrixOneRows.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        sliderMatrixOneRows.setMaximum(10);
        sliderMatrixOneRows.setMinimum(2);
        sliderMatrixOneRows.setSnapToTicks(true);
        sliderMatrixOneRows.setToolTipText("Matrix A rows");
        sliderMatrixOneRows.setValue(3);

        sliderMatrixOneColumns.setMaximum(10);
        sliderMatrixOneColumns.setMinimum(2);
        sliderMatrixOneColumns.setSnapToTicks(true);
        sliderMatrixOneColumns.setToolTipText("Matrix A columns");
        sliderMatrixOneColumns.setValue(3);

        sliderMatrixTwoRows.setMaximum(10);
        sliderMatrixTwoRows.setMinimum(2);
        sliderMatrixTwoRows.setSnapToTicks(true);
        sliderMatrixTwoRows.setToolTipText("Matrix B rows");
        sliderMatrixTwoRows.setValue(3);

        sliderMatrixTwoColumns.setMaximum(10);
        sliderMatrixTwoColumns.setMinimum(2);
        sliderMatrixTwoColumns.setSnapToTicks(true);
        sliderMatrixTwoColumns.setToolTipText("Matrix B columns");
        sliderMatrixTwoColumns.setValue(3);

        buttonMultiplyMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonMultiplyMatrices.setText("Multiply");
        buttonMultiplyMatrices.setToolTipText("");
        buttonMultiplyMatrices.setEnabled(false);
        buttonMultiplyMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonMultiplyMatrices_MouseClick(evt);
            }
        });

        buttonDivideMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonDivideMatrices.setText("Divide");
        buttonDivideMatrices.setEnabled(false);
        buttonDivideMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonDivideMatrices_MouseClick(evt);
            }
        });

        buttonSubtractMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonSubtractMatrices.setText("Subtract");
        buttonSubtractMatrices.setToolTipText("");
        buttonSubtractMatrices.setEnabled(false);
        buttonSubtractMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonSubtractMatrices_MouseClick(evt);
            }
        });

        buttonAddMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonAddMatrices.setText("Add");
        buttonAddMatrices.setEnabled(false);
        buttonAddMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonAddMatrices_MouseClick(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(30, 30, 30)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(matrixOneContainerScrollPane, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(70, 70, 70)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(buttonMultiplyMatrices, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(buttonDivideMatrices, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(buttonSubtractMatrices, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(buttonAddMatrices, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(matrixTwoContainerScrollPane, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(buttonGetFirstDeterminant)
                            .addComponent(buttonReverseRowsMatrixOne)
                            .addComponent(buttonGenerateMatrixOne)
                            .addComponent(buttonReverseColumnsMatrixOne)
                            .addComponent(sliderMatrixOneRows, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(sliderMatrixOneColumns, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 23, Short.MAX_VALUE)
                        .addComponent(resultScrollPane, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(buttonGetSecondDeterminant, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(sliderMatrixTwoRows, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(sliderMatrixTwoColumns, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(buttonReverseRowsMatrixTwo, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(buttonReverseColumnsMatrixTwo, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(buttonGenerateMatrixTwo, javax.swing.GroupLayout.Alignment.TRAILING))
                        .addGap(1, 1, 1)))
                .addGap(30, 30, 30))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(25, 25, 25)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                        .addComponent(matrixOneContainerScrollPane, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(matrixTwoContainerScrollPane, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(buttonMultiplyMatrices)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(buttonDivideMatrices)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(buttonSubtractMatrices)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(buttonAddMatrices)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(buttonGenerateMatrixOne)
                            .addComponent(buttonGenerateMatrixTwo))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(sliderMatrixOneRows, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(sliderMatrixOneColumns, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(buttonReverseRowsMatrixOne)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 11, Short.MAX_VALUE)
                                .addComponent(buttonReverseColumnsMatrixOne))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(sliderMatrixTwoRows, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(sliderMatrixTwoColumns, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(buttonReverseRowsMatrixTwo)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(buttonReverseColumnsMatrixTwo)))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 6, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(buttonGetFirstDeterminant)
                            .addComponent(buttonGetSecondDeterminant)))
                    .addComponent(resultScrollPane))
                .addGap(40, 40, 40))
        );

        buttonGenerateMatrixTwo.getAccessibleContext().setAccessibleName("buttonGenerateSecondMatrix");
        buttonGenerateMatrixTwo.getAccessibleContext().setAccessibleDescription("");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void buttonGenerateMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGenerateMatrixTwo_MouseClick
        // Generate new matrix B and display it
        int rows = sliderMatrixTwoRows.getValue();
        int columns = sliderMatrixTwoColumns.getValue();
        matrixTwo = new Matrix(rows, columns);
        
        String matrixToDisplay = matrixTwo.show();
        matrixTwoContainer.setText(matrixToDisplay);
        
        // Disable determinant button if matrix B has different rows and columns
        if (rows != columns)
            buttonGetSecondDeterminant.setEnabled(false);
        else
            buttonGetSecondDeterminant.setEnabled(true);
        
        if (matrixOne != null)
            disableMultiMatrixButtons();
    }//GEN-LAST:event_buttonGenerateMatrixTwo_MouseClick

    private void buttonGenerateMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGenerateMatrixOne_MouseClick
        // Generate new matrix A and display it
        int rows = sliderMatrixOneRows.getValue();
        int columns = sliderMatrixOneColumns.getValue();
        matrixOne = new Matrix(rows, columns);
        
        String matrixToDisplay = matrixOne.show();
        matrixOneContainer.setText(matrixToDisplay);
        
        // Disable determinant button if matrix A has different rows and columns
        if (rows != columns)
            buttonGetFirstDeterminant.setEnabled(false);
        else
            buttonGetFirstDeterminant.setEnabled(true);
        
        if (matrixTwo != null)
            disableMultiMatrixButtons();
    }//GEN-LAST:event_buttonGenerateMatrixOne_MouseClick

    private void buttonReverseRowsMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseRowsMatrixOne_MouseClick
        if (matrixOne == null)
            matrixOneContainer.setText("Matrix A is not generated");
        else {
            matrixOne.reverseRows();
            String matrixToDisplay = matrixOne.show();
            matrixOneContainer.setText(matrixToDisplay);
        }
    }//GEN-LAST:event_buttonReverseRowsMatrixOne_MouseClick

    private void buttonReverseRowsMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseRowsMatrixTwo_MouseClick
        if (matrixTwo == null)
            matrixTwoContainer.setText("Matrix B is not generated");
        else {
            matrixTwo.reverseRows();
            String matrixToDisplay = matrixTwo.show();
            matrixTwoContainer.setText(matrixToDisplay);
        }
    }//GEN-LAST:event_buttonReverseRowsMatrixTwo_MouseClick

    private void buttonReverseColumnsMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseColumnsMatrixOne_MouseClick
        if (matrixOne == null)
            matrixOneContainer.setText("Matrix A is not generated");
        else {
            matrixOne.reverseColumns();
            String matrixToDisplay = matrixOne.show();
            matrixOneContainer.setText(matrixToDisplay);
        }
    }//GEN-LAST:event_buttonReverseColumnsMatrixOne_MouseClick

    private void buttonReverseColumnsMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseColumnsMatrixTwo_MouseClick
        if (matrixTwo == null)
            matrixTwoContainer.setText("Matrix B is not generated");
        else {
            matrixTwo.reverseColumns();
            String matrixToDisplay = matrixTwo.show();
            matrixTwoContainer.setText(matrixToDisplay);
        }
    }//GEN-LAST:event_buttonReverseColumnsMatrixTwo_MouseClick

    private void buttonMultiplyMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonMultiplyMatrices_MouseClick
        resultArea.setText("Not yet implemented");
    }//GEN-LAST:event_buttonMultiplyMatrices_MouseClick

    private void buttonDivideMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonDivideMatrices_MouseClick
        resultArea.setText("Not yet implemented");
    }//GEN-LAST:event_buttonDivideMatrices_MouseClick

    private void buttonGetFirstDeterminant_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGetFirstDeterminant_MouseClick
        if (matrixOne == null)
            matrixOneContainer.setText("Matrix A is not generated");
        else if (matrixOne.getRows() > 3)
            matrixOneContainer.setText("Not yet implemented");
        else {
            resultArea.setText(
                String.format("Determinant of matrix A is %.2f", matrixOne.getDeterminant()));
        }
    }//GEN-LAST:event_buttonGetFirstDeterminant_MouseClick

    private void buttonGetSecondDeterminant_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGetSecondDeterminant_MouseClick
        if (matrixTwo == null)
            matrixTwoContainer.setText("Matrix B is not generated");
        else if (matrixTwo.getRows() > 3)
            matrixTwoContainer.setText("Not yet implemented");
        else {
            resultArea.setText(
                String.format("Determinant of matrix B is %.2f", matrixTwo.getDeterminant()));
        }
    }//GEN-LAST:event_buttonGetSecondDeterminant_MouseClick

    private void buttonSubtractMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonSubtractMatrices_MouseClick
        ExtendedMatrix tempMatrix = new ExtendedMatrix(matrixOne.getRows(), matrixOne.getColumns());
        tempMatrix = tempMatrix.subtractMatrix(matrixTwo.getMatrix());
        
        String matrixToDisplay = tempMatrix.show();
        resultArea.setText(matrixToDisplay);
    }//GEN-LAST:event_buttonSubtractMatrices_MouseClick

    private void buttonAddMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonAddMatrices_MouseClick
        ExtendedMatrix tempMatrix = new ExtendedMatrix(matrixOne.getRows(), matrixOne.getColumns());
        tempMatrix = tempMatrix.addMatrix(matrixTwo.getMatrix());
        
        String matrixToDisplay = tempMatrix.show();
        resultArea.setText(matrixToDisplay);
    }//GEN-LAST:event_buttonAddMatrices_MouseClick
    
    private void disableMultiMatrixButtons() {
        if (matrixOne.getRows() != matrixTwo.getColumns()) {
            buttonMultiplyMatrices.setEnabled(false);
            buttonDivideMatrices.setEnabled(false);
        }
        else {
            buttonMultiplyMatrices.setEnabled(true);
            buttonDivideMatrices.setEnabled(true);
        }
        
        if (matrixOne.getRows() != matrixTwo.getRows() ||
                matrixOne.getColumns() != matrixTwo.getColumns()) {
            buttonSubtractMatrices.setEnabled(false);
            buttonAddMatrices.setEnabled(false);
        }
        else {
            buttonSubtractMatrices.setEnabled(true);
            buttonAddMatrices.setEnabled(true);
        }
    }
    
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
            java.util.logging.Logger.getLogger(Main.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Main.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Main.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Main.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Main().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton buttonAddMatrices;
    private javax.swing.JButton buttonDivideMatrices;
    private javax.swing.JButton buttonGenerateMatrixOne;
    private javax.swing.JButton buttonGenerateMatrixTwo;
    private javax.swing.JButton buttonGetFirstDeterminant;
    private javax.swing.JButton buttonGetSecondDeterminant;
    private javax.swing.JButton buttonMultiplyMatrices;
    private javax.swing.JButton buttonReverseColumnsMatrixOne;
    private javax.swing.JButton buttonReverseColumnsMatrixTwo;
    private javax.swing.JButton buttonReverseRowsMatrixOne;
    private javax.swing.JButton buttonReverseRowsMatrixTwo;
    private javax.swing.JButton buttonSubtractMatrices;
    private javax.swing.JTextArea matrixOneContainer;
    private javax.swing.JScrollPane matrixOneContainerScrollPane;
    private javax.swing.JTextArea matrixTwoContainer;
    private javax.swing.JScrollPane matrixTwoContainerScrollPane;
    private javax.swing.JTextArea resultArea;
    private javax.swing.JScrollPane resultScrollPane;
    private javax.swing.JFrame rowsAndColsSet;
    private javax.swing.JSlider sliderMatrixOneColumns;
    private javax.swing.JSlider sliderMatrixOneRows;
    private javax.swing.JSlider sliderMatrixTwoColumns;
    private javax.swing.JSlider sliderMatrixTwoRows;
    // End of variables declaration//GEN-END:variables
}
