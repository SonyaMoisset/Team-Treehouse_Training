import React, { PropTypes } from 'react';

const Counter = props => 
  return (
    <div ClassName="counter">
      <button
        className="counter-action decrement"
        onClick={() => props.updatePlayerScore(props.index, -1)}>
        -
      </button>
      <div className="counter-score"> {props.score} </div>
      <button
        className="counter-action increment"
        onClick={() => props.updatePlayerScore(props.index, 1)}>
        +
      </button>
    </div>
  );

Counter.propTypes = {
  updatePlayerScore: PropTypes.func.isRequired,
  index: PropTypes.number.isRequired,
  score: PropTypes.number.isRequired
};

export default Counter;
