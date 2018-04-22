function solve([arr]) {
    arr = arr.split(' ').map(n =>Number(n));

    if(arr[0] + arr[1] == arr[2]){
        if(arr[1] < arr[0]){
            console.log(`${arr[1]} + ${arr[0]} = ${arr[2]}`)
        }
        else {
            console.log(`${arr[0]} + ${arr[1]} = ${arr[2]}`)
        }
    }
    else if(arr[1] + arr[2] == arr[0]){
        if(arr[2] < arr[1]){
            console.log(`${arr[2]} + ${arr[1]} = ${arr[0]}`)
        }
        else {
            console.log(`${arr[1]} + ${arr[2]} = ${arr[0]}`)
        }
    }
    else if(arr[0] + arr[2] == arr[1]){
        if(arr[2] < arr[0]){
            console.log(`${arr[2]} + ${arr[0]} = ${arr[1]}`)
        }
        else {
            console.log(`${arr[0]} + ${arr[2]} = ${arr[1]}`)
        }
    }
    else{
        console.log('No');
    }
}

solve(['8, 15, 7']);
solve(['-5 -3 -2']);
solve(['3 8 12']);