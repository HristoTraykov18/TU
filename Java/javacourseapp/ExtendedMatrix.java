
package javacourseapp;

// Class extending the base class's functionality
public class ExtendedMatrix extends Matrix {
    public ExtendedMatrix() {
        super();
    }
    
    public ExtendedMatrix(int rows, int columns) {
        super(rows, columns);
    }
    
    // Multiplication of a matrix with decimal number
    public ExtendedMatrix multiplyNumber(double multiplier) {
        ExtendedMatrix resultMatrix = new ExtendedMatrix();
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                resultMatrix.matrix[i][j] = matrix[i][j] * multiplier;
        }
        
        return resultMatrix;
    }
    
    // Multiplication of two matrices
    public ExtendedMatrix multiplyMatrix(ExtendedMatrix multiplicationMatrix) {
        ExtendedMatrix resultMatrix = new ExtendedMatrix();
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++) {
                
            }
        }
        
        return resultMatrix;
    }
    
    public ExtendedMatrix divideMatrix(double[][] divisionMatrix) {
        ExtendedMatrix resultMatrix = new ExtendedMatrix();
        // Inverted multiplication, implement invert() in Matrix
        return resultMatrix;
    }
    
    public ExtendedMatrix addMatrix(double[][] additionMatrix) {
        ExtendedMatrix resultMatrix = new ExtendedMatrix(matrixRows, matrixColumns);
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                resultMatrix.matrix[i][j] = matrix[i][j] + additionMatrix[i][j];
        }
        
        return resultMatrix;
    }
    
    public ExtendedMatrix subtractMatrix(double[][] subtractionMatrix) {
        ExtendedMatrix resultMatrix = new ExtendedMatrix(matrixRows, matrixColumns);
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                resultMatrix.matrix[i][j] = matrix[i][j] - subtractionMatrix[i][j];
        }
        
        return resultMatrix;
    }
}
