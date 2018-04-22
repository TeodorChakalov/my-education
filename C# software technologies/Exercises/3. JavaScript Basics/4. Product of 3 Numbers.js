function solve(arr) {
    let firstNumber = Number(arr[0]);
    let secondNumber = Number(arr[1]);
    let thirdNumber = Number(arr[2]);

    let negativeCounter = 0;

    if(firstNumber < 0){
        negativeCounter++;
    }
    if(secondNumber < 0){
        negativeCounter++;
    }
    if(thirdNumber<0){
        negativeCounter++;
    }

    if(negativeCounter % 2 == 0){
        console.log("Positive");
    }
    else {
        console.log("Negative");
    }
}

solve([2, 3, -1])
solve([5, 4, 3])