import UIKit

let implicitInterger = 70
let implicitDouble = 70.0
let exlicitDouble: Double = 70
///print
print(implicitInterger)
print(implicitDouble)
print(exlicitDouble)
///
///
let label = "The width is "
let width = 94
let widthLabel = label + String(width)
print(widthLabel)

let apples = 3
let oranges = 4
let appleSummary = "I have \(apples) apples."
let orangesSummary = "I have \(oranges) oranges."
print(appleSummary)
print(orangesSummary)

var shoppingList = ["catFish", "water", "tulips"]
shoppingList[1] = "bottle of water"
var ocupations = ["Malcolm":"Captain", "Kaylee":"Mechanic"]
ocupations["Jayne"] = "Public Relation"
shoppingList.append("blue paint")
print(shoppingList)
print(ocupations)

let emptyArray = [String]()
let emptyDictionary = [String: Float]()

let individualScores = [75,43,103,87,12]
var teamScore = 0
for score in individualScores{
    if(score > 50){
        teamScore+=3
    }else{
        teamScore+=1
    }
}
print(teamScore)

var optinalString: String? = "hello"
print(optinalString == nil)
var optinalName: String? = "How are you"
var greeting = "Hello!"
if let name = optinalName{
    greeting = "Hello, \(name)"
}
print(greeting)
