function solve(arr) {
    let firstNumber = Number(arr[0]);
    let secondNumber = Number(arr[1]);

    if(firstNumber <= secondNumber){
        let result = firstNumber * secondNumber;
        console.log(result);
    }
    else {
        let result = firstNumber / secondNumber;
        console.log(result);
    }
}
solve([3, 2])