
package CourseAppGUI;
import javacourseapp.Matrix;
import javacourseapp.ExtendedMatrix;
import javax.swing.JTextArea;

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
        buttonGetDeterminantMatrixOne = new javax.swing.JButton();
        buttonGetDeterminantMatrixTwo = new javax.swing.JButton();
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
        buttonTransposeMatrixOne = new javax.swing.JButton();
        buttonTransposeMatrixTwo = new javax.swing.JButton();
        buttonSumMatrixOne = new javax.swing.JButton();
        buttonSumMatrixTwo = new javax.swing.JButton();

        rowsAndColsSet.setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        rowsAndColsSet.setTitle("Matrix row and column select");
        rowsAndColsSet.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
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
        buttonGenerateMatrixOne.setInheritsPopupMenu(true);
        buttonGenerateMatrixOne.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGenerateMatrixOne_MouseClick(evt);
            }
        });

        buttonGenerateMatrixTwo.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonGenerateMatrixTwo.setText("Generate matrix");
        buttonGenerateMatrixTwo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGenerateMatrixTwo_MouseClick(evt);
            }
        });

        matrixOneContainer.setEditable(false);
        matrixOneContainer.setBackground(new java.awt.Color(255, 255, 255));
        matrixOneContainer.setColumns(20);
        matrixOneContainer.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
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

        matrixTwoContainer.setEditable(false);
        matrixTwoContainer.setBackground(new java.awt.Color(255, 255, 255));
        matrixTwoContainer.setColumns(20);
        matrixTwoContainer.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        matrixTwoContainer.setForeground(new java.awt.Color(0, 0, 0));
        matrixTwoContainer.setRows(5);
        matrixTwoContainer.setTabSize(4);
        matrixTwoContainer.setToolTipText("When generated, matrix B will be displayed");
        matrixTwoContainer.setCaretColor(new java.awt.Color(255, 255, 255));
        matrixTwoContainer.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        matrixTwoContainer.setRequestFocusEnabled(false);
        matrixTwoContainerScrollPane.setViewportView(matrixTwoContainer);

        buttonGetDeterminantMatrixOne.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonGetDeterminantMatrixOne.setText("Get determinant");
        buttonGetDeterminantMatrixOne.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGetDeterminantMatrixOne_MouseClick(evt);
            }
        });

        buttonGetDeterminantMatrixTwo.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonGetDeterminantMatrixTwo.setText("Get determinant");
        buttonGetDeterminantMatrixTwo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonGetDeterminantMatrixTwo_MouseClick(evt);
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

        sliderMatrixOneRows.setFont(new java.awt.Font("Verdana", 0, 10)); // NOI18N
        sliderMatrixOneRows.setForeground(new java.awt.Color(0, 0, 0));
        sliderMatrixOneRows.setMajorTickSpacing(1);
        sliderMatrixOneRows.setMaximum(10);
        sliderMatrixOneRows.setMinimum(1);
        sliderMatrixOneRows.setPaintLabels(true);
        sliderMatrixOneRows.setSnapToTicks(true);
        sliderMatrixOneRows.setToolTipText("Matrix A rows");
        sliderMatrixOneRows.setValue(3);

        sliderMatrixOneColumns.setFont(new java.awt.Font("Verdana", 0, 10)); // NOI18N
        sliderMatrixOneColumns.setForeground(new java.awt.Color(0, 0, 0));
        sliderMatrixOneColumns.setMajorTickSpacing(1);
        sliderMatrixOneColumns.setMaximum(10);
        sliderMatrixOneColumns.setMinimum(1);
        sliderMatrixOneColumns.setPaintLabels(true);
        sliderMatrixOneColumns.setSnapToTicks(true);
        sliderMatrixOneColumns.setToolTipText("Matrix A columns");
        sliderMatrixOneColumns.setValue(3);

        sliderMatrixTwoRows.setFont(new java.awt.Font("Verdana", 0, 10)); // NOI18N
        sliderMatrixTwoRows.setForeground(new java.awt.Color(0, 0, 0));
        sliderMatrixTwoRows.setMajorTickSpacing(1);
        sliderMatrixTwoRows.setMaximum(10);
        sliderMatrixTwoRows.setMinimum(1);
        sliderMatrixTwoRows.setPaintLabels(true);
        sliderMatrixTwoRows.setSnapToTicks(true);
        sliderMatrixTwoRows.setToolTipText("Matrix B rows");
        sliderMatrixTwoRows.setValue(3);

        sliderMatrixTwoColumns.setFont(new java.awt.Font("Verdana", 0, 10)); // NOI18N
        sliderMatrixTwoColumns.setForeground(new java.awt.Color(0, 0, 0));
        sliderMatrixTwoColumns.setMajorTickSpacing(1);
        sliderMatrixTwoColumns.setMaximum(10);
        sliderMatrixTwoColumns.setMinimum(1);
        sliderMatrixTwoColumns.setPaintLabels(true);
        sliderMatrixTwoColumns.setSnapToTicks(true);
        sliderMatrixTwoColumns.setToolTipText("Matrix B columns");
        sliderMatrixTwoColumns.setValue(3);

        buttonMultiplyMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonMultiplyMatrices.setText("Multiply");
        buttonMultiplyMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonMultiplyMatrices_MouseClick(evt);
            }
        });

        buttonDivideMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonDivideMatrices.setText("Divide");
        buttonDivideMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonDivideMatrices_MouseClick(evt);
            }
        });

        buttonSubtractMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonSubtractMatrices.setText("Subtract");
        buttonSubtractMatrices.setToolTipText("");
        buttonSubtractMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonSubtractMatrices_MouseClick(evt);
            }
        });

        buttonAddMatrices.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonAddMatrices.setText("Add");
        buttonAddMatrices.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonAddMatrices_MouseClick(evt);
            }
        });

        buttonTransposeMatrixOne.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonTransposeMatrixOne.setText("Transpose");
        buttonTransposeMatrixOne.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonTransposeMatrixOne_MouseClick(evt);
            }
        });

        buttonTransposeMatrixTwo.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonTransposeMatrixTwo.setText("Transpose");
        buttonTransposeMatrixTwo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonTransposeMatrixTwo_MouseClick(evt);
            }
        });

        buttonSumMatrixOne.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonSumMatrixOne.setText("Sum numbers");
        buttonSumMatrixOne.setToolTipText("Sums all numbers in matrix A");
        buttonSumMatrixOne.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonSumMatrixOne_MouseClick(evt);
            }
        });

        buttonSumMatrixTwo.setFont(new java.awt.Font("Verdana", 1, 13)); // NOI18N
        buttonSumMatrixTwo.setText("Sum numbers");
        buttonSumMatrixTwo.setToolTipText("Sums all numbers in matrix B");
        buttonSumMatrixTwo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                buttonSumMatrixTwo_MouseClick(evt);
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
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 70, Short.MAX_VALUE)
                        .addComponent(matrixTwoContainerScrollPane, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(buttonGetDeterminantMatrixOne)
                                    .addComponent(buttonReverseRowsMatrixOne)
                                    .addComponent(buttonGenerateMatrixOne)
                                    .addComponent(buttonReverseColumnsMatrixOne)
                                    .addComponent(sliderMatrixOneRows, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(sliderMatrixOneColumns, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(buttonTransposeMatrixOne))
                                .addGap(18, 18, 18)
                                .addComponent(resultScrollPane)
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(sliderMatrixTwoRows, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(sliderMatrixTwoColumns, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addComponent(buttonReverseRowsMatrixTwo)
                                    .addComponent(buttonGenerateMatrixTwo)
                                    .addComponent(buttonReverseColumnsMatrixTwo)
                                    .addComponent(buttonGetDeterminantMatrixTwo)
                                    .addComponent(buttonTransposeMatrixTwo)))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(buttonSumMatrixOne)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addComponent(buttonSumMatrixTwo)))
                        .addGap(1, 1, 1)))
                .addGap(30, 30, 30))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(20, 20, 20)
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
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addComponent(sliderMatrixTwoRows, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(1, 1, 1)
                                .addComponent(sliderMatrixTwoColumns, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(12, 12, 12)
                                .addComponent(buttonReverseRowsMatrixTwo)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(buttonReverseColumnsMatrixTwo))
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addComponent(sliderMatrixOneRows, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(1, 1, 1)
                                .addComponent(sliderMatrixOneColumns, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(12, 12, 12)
                                .addComponent(buttonReverseRowsMatrixOne)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(buttonReverseColumnsMatrixOne)))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(buttonGetDeterminantMatrixOne)
                            .addComponent(buttonGetDeterminantMatrixTwo))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(buttonTransposeMatrixOne)
                            .addComponent(buttonTransposeMatrixTwo)))
                    .addComponent(resultScrollPane, javax.swing.GroupLayout.PREFERRED_SIZE, 225, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(buttonSumMatrixOne)
                    .addComponent(buttonSumMatrixTwo))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        buttonGenerateMatrixTwo.getAccessibleContext().setAccessibleName("buttonGenerateSecondMatrix");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void buttonGenerateMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGenerateMatrixTwo_MouseClick
        // Generate new matrix B and display it
        int rows = sliderMatrixTwoRows.getValue();
        int columns = sliderMatrixTwoColumns.getValue();
        matrixTwo = new Matrix(rows, columns);
        
        displayResult(matrixTwo, matrixTwoContainer, matrixTwo.show());
    }//GEN-LAST:event_buttonGenerateMatrixTwo_MouseClick

    private void buttonGenerateMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGenerateMatrixOne_MouseClick
        // Generate new matrix A and display it
        int rows = sliderMatrixOneRows.getValue();
        int columns = sliderMatrixOneColumns.getValue();
        matrixOne = new Matrix(rows, columns);
        
        displayResult(matrixOne, matrixOneContainer, matrixOne.show());
    }//GEN-LAST:event_buttonGenerateMatrixOne_MouseClick

    private void buttonReverseRowsMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseRowsMatrixOne_MouseClick
        if (matrixIsGenerated(matrixOne, matrixOneContainer)) {
            matrixOne.reverseRows();
            displayResult(matrixOne, matrixOneContainer, matrixOne.show());
        }
    }//GEN-LAST:event_buttonReverseRowsMatrixOne_MouseClick

    private void buttonReverseRowsMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseRowsMatrixTwo_MouseClick
         if (matrixIsGenerated(matrixTwo, matrixTwoContainer)) {
            matrixTwo.reverseRows();
            displayResult(matrixTwo, matrixTwoContainer, matrixTwo.show());
        }
    }//GEN-LAST:event_buttonReverseRowsMatrixTwo_MouseClick

    private void buttonReverseColumnsMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseColumnsMatrixOne_MouseClick
        if (matrixIsGenerated(matrixOne, matrixOneContainer)) {
            matrixOne.reverseColumns();
            displayResult(matrixOne, matrixOneContainer, matrixOne.show());
        }
    }//GEN-LAST:event_buttonReverseColumnsMatrixOne_MouseClick

    private void buttonReverseColumnsMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonReverseColumnsMatrixTwo_MouseClick
        if (matrixIsGenerated(matrixTwo, matrixTwoContainer)) {
            matrixTwo.reverseColumns();
            displayResult(matrixTwo, matrixTwoContainer, matrixTwo.show());
        }
    }//GEN-LAST:event_buttonReverseColumnsMatrixTwo_MouseClick

    private void buttonMultiplyMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonMultiplyMatrices_MouseClick
        if (canMultiplyOrDivideMatrices()) {
            ExtendedMatrix tempMatrix = new ExtendedMatrix(matrixOne);
            tempMatrix = tempMatrix.multiplyMatrix(matrixTwo);

            displayResult(tempMatrix, resultArea, tempMatrix.show());
        }
    }//GEN-LAST:event_buttonMultiplyMatrices_MouseClick

    private void buttonDivideMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonDivideMatrices_MouseClick
        if (canMultiplyOrDivideMatrices() && isSquareMatrix(matrixTwo)) {
            ExtendedMatrix tempMatrix = new ExtendedMatrix(matrixOne);
            tempMatrix = tempMatrix.divideMatrix(matrixTwo);

            displayResult(tempMatrix, resultArea, tempMatrix.show());
        }
    }//GEN-LAST:event_buttonDivideMatrices_MouseClick

    private void buttonGetDeterminantMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGetDeterminantMatrixOne_MouseClick
        if (matrixIsGenerated(matrixOne, matrixOneContainer) && isSquareMatrix(matrixOne)) {
            resultArea.setText(
                String.format("Determinant of matrix A is %.2f", matrixOne.getDeterminant()));
        }
    }//GEN-LAST:event_buttonGetDeterminantMatrixOne_MouseClick

    private void buttonGetDeterminantMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonGetDeterminantMatrixTwo_MouseClick
        if (matrixIsGenerated(matrixTwo, matrixTwoContainer) && isSquareMatrix(matrixTwo)) {
            resultArea.setText(
                    String.format("Determinant of matrix B is %.2f", matrixTwo.getDeterminant()));
        }
    }//GEN-LAST:event_buttonGetDeterminantMatrixTwo_MouseClick

    private void buttonSubtractMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonSubtractMatrices_MouseClick
        if (canSubtractOrAddMatrices()) {
            ExtendedMatrix tempMatrix = new ExtendedMatrix(matrixOne);
            tempMatrix.subtractMatrix(matrixTwo.getMatrix());

            displayResult(tempMatrix, resultArea, tempMatrix.show());
        }
    }//GEN-LAST:event_buttonSubtractMatrices_MouseClick

    private void buttonAddMatrices_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonAddMatrices_MouseClick
        if (canSubtractOrAddMatrices()) {
            ExtendedMatrix tempMatrix = new ExtendedMatrix(matrixOne);
            tempMatrix = tempMatrix.addMatrix(matrixTwo.getMatrix());

            displayResult(tempMatrix, resultArea, tempMatrix.show());
        }
    }//GEN-LAST:event_buttonAddMatrices_MouseClick

    private void buttonTransposeMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonTransposeMatrixOne_MouseClick
        if (matrixIsGenerated(matrixOne, matrixOneContainer)) {
            matrixOne.transposeMatrix();
            displayResult(matrixOne, matrixOneContainer, matrixOne.show());
        }
    }//GEN-LAST:event_buttonTransposeMatrixOne_MouseClick

    private void buttonTransposeMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonTransposeMatrixTwo_MouseClick
        if (matrixIsGenerated(matrixTwo, matrixTwoContainer)) {
            matrixTwo.transposeMatrix();
            displayResult(matrixTwo, matrixTwoContainer, matrixTwo.show());
        }
    }//GEN-LAST:event_buttonTransposeMatrixTwo_MouseClick

    private void buttonSumMatrixOne_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonSumMatrixOne_MouseClick
        if (matrixIsGenerated(matrixOne, matrixOneContainer)) {
            String textToDisplay = String.format(
                "The sum of the elements in matrix A is: %.2f", matrixOne.sumElements());
            
            displayResult(matrixOne, resultArea, textToDisplay);
        }
    }//GEN-LAST:event_buttonSumMatrixOne_MouseClick

    private void buttonSumMatrixTwo_MouseClick(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_buttonSumMatrixTwo_MouseClick
        if (matrixIsGenerated(matrixTwo, matrixTwoContainer)) {
            String textToDisplay = String.format(
                "The sum of the elements in matrix B is: %.2f", matrixTwo.sumElements());
            
            displayResult(matrixTwo, resultArea, textToDisplay);
        }
    }//GEN-LAST:event_buttonSumMatrixTwo_MouseClick

    // Display matrix in the according field
    private void displayResult(Matrix m, JTextArea displayArea, String text) {
        displayArea.setText(text);
    }
    
    // Check if the matrix is generated and send message if it's not
    private boolean matrixIsGenerated(Matrix m, JTextArea displayArea) {
        if (m == null) {
            displayArea.setText("The matrix does not exist yet.\n"
                    + "Please generate it first");
            
            return false;
        }
        
        return true;
    }
    
    private boolean isSquareMatrix(Matrix m) {
        if (m.getRows()  == m.getColumns())
            return true;
        
        resultArea.setText("Non-square matrix!");
        
        return false;
    }
    
    // Buttons subtract and add in the top middle of the screen
    private boolean canSubtractOrAddMatrices() {
        if (matrixOne != null && matrixTwo != null &&
            matrixOne.getRows() == matrixTwo.getRows() &&
            matrixOne.getColumns() == matrixTwo.getColumns())
            return true;
        
        resultArea.setText("Matrices should have equal rows and columns!\n"
                + "They may not be square matrices.");
        
        return false;
    }
    
    // Buttons subtract and add in the top middle of the screen
    private boolean canMultiplyOrDivideMatrices() {
        if (matrixOne != null && matrixTwo != null && 
            matrixOne.getColumns() == matrixTwo.getRows()) {
            return true;
        }
        
        resultArea.setText("Matrix A columns should be equal to matrix B rows!");
        
        return false;
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
        java.awt.EventQueue.invokeLater(() -> {
            new Main().setVisible(true);
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton buttonAddMatrices;
    private javax.swing.JButton buttonDivideMatrices;
    private javax.swing.JButton buttonGenerateMatrixOne;
    private javax.swing.JButton buttonGenerateMatrixTwo;
    private javax.swing.JButton buttonGetDeterminantMatrixOne;
    private javax.swing.JButton buttonGetDeterminantMatrixTwo;
    private javax.swing.JButton buttonMultiplyMatrices;
    private javax.swing.JButton buttonReverseColumnsMatrixOne;
    private javax.swing.JButton buttonReverseColumnsMatrixTwo;
    private javax.swing.JButton buttonReverseRowsMatrixOne;
    private javax.swing.JButton buttonReverseRowsMatrixTwo;
    private javax.swing.JButton buttonSubtractMatrices;
    private javax.swing.JButton buttonSumMatrixOne;
    private javax.swing.JButton buttonSumMatrixTwo;
    private javax.swing.JButton buttonTransposeMatrixOne;
    private javax.swing.JButton buttonTransposeMatrixTwo;
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
