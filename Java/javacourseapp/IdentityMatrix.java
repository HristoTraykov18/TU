
package javacourseapp;

// Identity matrix class
public class IdentityMatrix extends Matrix {
    public IdentityMatrix(int rows) {
        matrixRows = rows;
        matrixColumns = rows;
        matrix = new double[matrixRows][matrixColumns];
        
        for (int i = 0; i < rows; i++)
            matrix[i][i] = 1;
    }
}
