/*

NQueens

*/

    bool isAvailable(const vector<int> &solution, int i, int j) {
        for (int k = 0; k < i; ++k) {
            if (j == solution[k] || i + j == k + solution[k] || i - j == k - solution[k]) return false;
        }
        return true;
    }
        vector<string> solToStrings(const vector<int>& sol) {
        int n = sol.size();
        vector<string> sol_strings(n);
        for (int i = 0; i < n; ++i) {
            sol_strings[i] = string(n, '.');
            sol_strings[i][sol[i]] = 'Q';
        }
        return sol_strings;
    }

void solveNQueensImpl(int row, vector<int> &solution, vector<vector<string> > &solutions) {
        int n = solution.size();
        if (row == n) {
            solutions.push_back(solToStrings(solution));
            return;
        }
        // For each column...
        for (int j = 0; j < n; ++j) {
            // Skip if there is another queen in this column or diagonals
            if (isAvailable(solution, row, j)) {
                solution[row] = j;
                solveNQueensImpl(row + 1, solution, solutions);
            }
        }
    }

vector<vector<string> > Solution::solveNQueens(int A) {
    // Do not write main() function.
    // Do not read input, instead use the arguments to the function.
    // Do not print the output, instead return values as specified
    // Still have a doubt. Checkout www.interviewbit.com/pages/sample_codes/ for more details
            vector<vector<string> > solutions;
        vector<int> solution(A);
        solveNQueensImpl(0, solution, solutions);
        return solutions;
}

