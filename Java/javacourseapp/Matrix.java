
package javacourseapp;
import java.util.Random;

// Base matrix class
public class Matrix {
    int matrixRows = 3;
    int matrixColumns = 3;
    double[][] matrix = null;
    
    public Matrix() {
        // Empty constructor preventing errors
    }
    
    public Matrix(int rows, int columns) {
        matrixRows = rows;
        matrixColumns = columns;
        matrix = new double[matrixRows][matrixColumns];
        
        fillRandomMatrixValues();
    }
    
    private void fillRandomMatrixValues() {
        Random rand = new Random();
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++) {
                // Generate random number, format it and save it in the matrix
                matrix[i][j] = (Math.round((rand.nextDouble() * 10) * 100)) / 100.0;
            }
        }
    }
    
    public int getRows() {
        return matrixRows;
    }
    
    public int getColumns() {
        return matrixColumns;
    }
    
    // Return new instance of the matrix to prevent overriding
    public double[][] getMatrix() {
        double[][] returnMatrix = new double[matrixRows][matrixColumns];
        
        for (int i = 0; i < matrixRows; i++)
            System.arraycopy(matrix[i], 0, returnMatrix[i], 0, matrixColumns);
        
        return returnMatrix;
    }
    
    // Display the matrix
    public String show() {
        String result = "";
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++) {
                result += String.format("%.2f", matrix[i][j]);
                
                if (j < matrixColumns - 1)
                    result += "\t";
            }
                
            if (i < matrixRows - 1)
                result += "\n";
        }
        
        return result;
    }
    
    // Reverse each row in the matrix
    public void reverseRows() {
        for (int i = 0; i < matrixRows / 2; i++) {
            for (int j = 0; j < matrixColumns; j++) {
                double temp = matrix[matrixRows - i - 1][j];
                matrix[matrixRows - i - 1][j] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }
    }
    
    // Reverse each column in the matrix
    public void reverseColumns() {
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns / 2; j++) {
                double temp = matrix[i][matrixColumns - j - 1];
                matrix[i][matrixColumns - j - 1] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }
    }
    
    // Matrix rows become matrix columns
    public void transposeMatrix() {
        if (matrixRows == matrixColumns) {
            for (int i = 0; i < matrixRows - 1; i++) {
                for (int j = i; j < matrixColumns; j++) {                    
                    double tempVal = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = tempVal;
                }
            }
        }
        else {
            double[][] tempMatrix = new double[matrixColumns][matrixRows];
            
            for (int i = 0; i < matrixRows; i++) {
                for (int j = 0; j < matrixColumns; j++)
                    tempMatrix[j][i] = matrix[i][j];
            }
            
            int tempValue = matrixRows;
            matrixRows = matrixColumns;
            matrixColumns = tempValue;
            matrix = tempMatrix;
        }
    }
    
    // Sum all elements in the matrix
    public double sumElements() {
        double sum = 0;
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                sum += matrix[i][j];
        }
        
        return sum;
    }
    
    // Get a square matrix determinant
    public double getDeterminant() {
        double determinant = 0;
        
        if (matrixRows == matrixColumns && matrixRows > 1) {
            switch(matrixRows) {
                case 2:
                    // Formula for determinant of matrix 2x2
                    determinant = (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
                    break;

                case 3:
                    // Leibniz formula for determinant of matrix 3x3
                    determinant = ((matrix[0][0] * ((matrix[1][1] * matrix[2][2]) - (matrix[1][2] * matrix[2][1]))) -
                            (matrix[0][1] * ((matrix[1][0] * matrix[2][2]) - (matrix[2][0] * matrix[1][2]))) +
                            (matrix[0][2] * ((matrix[1][0] * matrix[2][1]) - (matrix[1][1] * matrix[2][0]))));
                    
                    break;

                default:
                    double[][] tempMatrix = getMatrix();
                    
                    determinant = tempMatrix[0][0];
                    
                    // Formula for determinant of matrix 4x4 and above
                    // Set everything below the main diagonal to 0
                    // and get the product of the numbers in the main diagonal
                    for (int i = 0; i < matrixRows; i++) {
                        if (i > 0) {
                            for (int k = 0; k < i; k++) {
                                for (int j = matrixColumns - 1; j >= 0; j--)
                                    tempMatrix[i][j] -= tempMatrix[i][k] * tempMatrix[k][j];
                            }

                            determinant *= tempMatrix[i][i];
                        }
                        
                        if (tempMatrix[i][i] == 0) {
                            determinant = 0;
                            
                            break;
                        }
                        
                        for (int j = matrixColumns - 1; j >= i; j--) {
                            if (i > 0)
                                tempMatrix[i - 1][j] *= tempMatrix[i - 1][i - 1];
                            
                            tempMatrix[i][j] /= tempMatrix[i][i];
                        }
                    }
                    
                    break;
            }
        }
        
        return determinant;
    }
}
