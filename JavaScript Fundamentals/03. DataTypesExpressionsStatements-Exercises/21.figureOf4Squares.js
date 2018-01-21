function drawFourSquares(n) {
    if (n % 2 === 0) {
        for (let i = 1; i < n; i++) {
            if(i===1){
                console.log('+' + '-'.repeat(n - 2) + '+' + '-'.repeat(n - 2) + '+');
                continue
            }
            else if (i===n-1) {
                console.log('+' + '-'.repeat(n - 2) + '+' + '-'.repeat(n - 2) + '+');
                break;
            }
            if (i === n / 2) {
                console.log('+' + '-'.repeat(n - 2) + '+' + '-'.repeat(n - 2) + '+');
            }
            else {
                console.log('|' + ' '.repeat(n - 2) + '|' + ' '.repeat(n - 2) + '|');
            }
        }
    }

    else {
        for (let i = 1; i <= n; i++) {
            if(i===1){
                console.log('+' + '-'.repeat(n - 2) + '+' + '-'.repeat(n - 2) + '+');
                continue
            }
            else if (i===n) {
                console.log('+' + '-'.repeat(n - 2) + '+' + '-'.repeat(n - 2) + '+');
                break;
            }
            if (i === (n+1) / 2) {
                console.log('+' + '-'.repeat(n - 2) + '+' + '-'.repeat(n - 2) + '+');
            }
            else {
                console.log('|' + ' '.repeat(n - 2) + '|' + ' '.repeat(n - 2) + '|');
            }
        }
    }
}