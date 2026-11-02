let displayValue = '';
let justCalculated = false;
const display = document.getElementById('display');

function updateDisplay() {
  display.textContent = displayValue || '0';
}

function clearDisplay() {
  displayValue = '';
  justCalculated = false;
  updateDisplay();
}

function input(char) {
  const isOperator = ['+', '-', '*', '/'].includes(char);

  if (displayValue === 'Error' || (justCalculated && !isOperator)) {
    displayValue = '';
  }
  justCalculated = false;

  const currentNum = displayValue.split(/[+*/-]/).pop();

  if (char === '.') {
    if (currentNum.includes('.')) return;
    displayValue += currentNum ? '.' : '0.';
  } else if (isOperator) {
    if (!displayValue) return;
    displayValue = /[+*/-]$/.test(displayValue)
      ? displayValue.slice(0, -1) + char
      : displayValue + char;
  } else {
    if (currentNum === '0') displayValue = displayValue.slice(0, -1);
    displayValue += char;
  }

  updateDisplay();
}

function calculate() {
  if (!displayValue || displayValue === 'Error') return false;

  try {
    const result = Function(`'use strict'; return (${displayValue})`)();
    if (!Number.isFinite(result)) throw new Error();

    displayValue = String(Number(result.toPrecision(12)));
    justCalculated = true;
    updateDisplay();
    return true;
  } catch {
    displayValue = 'Error';
    justCalculated = false;
    updateDisplay();
    return false;
  }
}

function modifyResult(multiplier) {
  if (calculate()) {
    displayValue = String(Number((Number(displayValue) * multiplier).toPrecision(12)));
    updateDisplay();
  }
}


document.querySelector('.buttons').addEventListener('click', (e) => {
  const btn = e.target.closest('button');
  if (!btn || btn.hasAttribute('onclick')) return;

  const val = btn.textContent.trim();
  if (val === 'AC') clearDisplay();
  else if (val === '=') calculate();
  else if (val === '+/-') modifyResult(-1);
  else if (val === '%') modifyResult(0.01);
  else input(val);
});


const appendNumber = (n) => input(String(n));
const appendOperator = (op) => input(op);
const toggleSign = () => modifyResult(-1);
const percent = () => modifyResult(0.01);