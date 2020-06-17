
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
        
        fillMatrix();
    }
    
    private void fillMatrix() {
        Random rand = new Random();
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++) {
                // Generate random number, format it and save it in the matrix
                matrix[i][j] = (Math.round((rand.nextDouble() * 20) * 100)) / 100.0;
            }
        }
    }
    
    public int getRows() {
        return matrixRows;
    }
    
    public int getColumns() {
        return matrixColumns;
    }
    
    public double[][] getMatrix() {
        return matrix;
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
    
    // Sum all elements in the matrix
    public double sumElements() {
        double sum = 0;
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                sum += matrix[i][j];
        }
        
        return sum;
    }
    
    public double getBiggestNumber() {
        double biggestNumber = Double.MIN_VALUE;
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                biggestNumber = matrix[i][j] > biggestNumber ? matrix[i][j] : biggestNumber;
        }
        
        return 1;
    }
    
    public double getSmallestNumber() {
        double smallestNumber = Double.MAX_VALUE;
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                smallestNumber = matrix[i][j] < smallestNumber ? matrix[i][j] : smallestNumber;
        }
        
        return 1;
    }
    
    // Get a square matrix determinant through it's diagonals
    public double getDeterminant() {
        double determinant = 0;
        
        switch(matrixRows) {
            case 2:
                determinant = (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
                break;
            
            case 3:
                // Leibniz formula for determinant of matrix 3x3
                determinant = ((matrix[0][0] * ((matrix[1][1] * matrix[2][2]) - (matrix[1][2] * matrix[2][1]))) -
                        (matrix[0][1] * ((matrix[1][0] * matrix[2][2]) - (matrix[2][0] * matrix[1][2]))) +
                        (matrix[0][2] * ((matrix[1][0] * matrix[2][1]) - (matrix[1][1] * matrix[2][0]))));
                break;
            
            default:
                // Not yet implemented for matrices 4x4 and above
                break;
        }
        
        return determinant;
    }
}
