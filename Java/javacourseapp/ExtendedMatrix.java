
package javacourseapp;

// Class extending the base class's functionality
public class ExtendedMatrix extends Matrix {
    public ExtendedMatrix(Matrix baseMatrix) {
        matrixRows = baseMatrix.getRows();
        matrixColumns = baseMatrix.getColumns();
        matrix = new double[matrixRows][matrixColumns];
        matrix = baseMatrix.getMatrix();
    }
    
    // Multiplication of a matrix with decimal number
    public ExtendedMatrix multiplyNumber(double multiplier) {
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                matrix[i][j] *= multiplier;
        }
        
        return this;
    }
    
    // Multiplication of two matrices
    public ExtendedMatrix multiplyMatrix(Matrix multiplicationMatrix) {
        int columns = multiplicationMatrix.getColumns();
        double[][] tempMatrix = new double[matrixRows][columns];
        double[][] multiplierMatrix = multiplicationMatrix.getMatrix();
        
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < columns; j++) {
                for (int k = 0; k < matrixColumns; k++)
                    tempMatrix[i][j] += matrix[i][k] * multiplierMatrix[k][j];
            }
        }
        
        matrixColumns = columns;
        matrix = tempMatrix;
        
        return this;
    }
    
    // Division of two matrices
    public ExtendedMatrix divideMatrix(Matrix divisionMatrix) {
        // Use temporary matrix in order to keep the original
        ExtendedMatrix inversedMatrix = new ExtendedMatrix(divisionMatrix);
        inversedMatrix = inversedMatrix.inverseMatrix();
        
        return multiplyMatrix(inversedMatrix);
    }
    
    // Addition of two matrices
    public ExtendedMatrix addMatrix(double[][] additionMatrix) {
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                matrix[i][j] += additionMatrix[i][j];
        }
        
        return this;
    }
    
    // Subtraction of two matrices
    public ExtendedMatrix subtractMatrix(double[][] subtractionMatrix) {
        for (int i = 0; i < matrixRows; i++) {
            for (int j = 0; j < matrixColumns; j++)
                matrix[i][j] -= subtractionMatrix[i][j];
        }
        
        return this;
    }
    
    private ExtendedMatrix inverseMatrix() {
        IdentityMatrix identityMatrix = 
            new IdentityMatrix(getRows());
        
        return multiplyMatrix(identityMatrix);
    }
}
