function ShowPrompt(text)
{
    return prompt(text, 'Type your name here');
}

function DisplayWelcome(welcomeMessage)
{
    document.getElementById('welcome').innerHTML = welcomeMessage;
}