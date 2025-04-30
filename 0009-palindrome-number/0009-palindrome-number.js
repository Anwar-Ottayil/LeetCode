/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    let str =x.toString();
    let strrev=str.split('').reverse().join('');
    return str===strrev;
    
};
