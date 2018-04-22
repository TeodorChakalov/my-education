function s(arr) {
    let nums = arr.map(n => Number(n));
    let numsSorted = nums.sort((a, b) => b - a);
    let count = Math.min(3, arr.length);
    for(let i = 0; i < count; i++){
        console.log(numsSorted[i]);
    }
}
s(['10', '30', '15', '20', '50', '5']);