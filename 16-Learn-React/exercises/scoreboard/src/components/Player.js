import React, { PropTypes } from 'react';
import Counter from './Counter';

const Player = props => {
  return (
    <div className="player">
      <div 
        className="player-name"
        onClick={() => props.selectPlayer(props.index)}>
        <a 
          className="remove-player"
          onClick={() => props.removePlayer(props.index)}>
          X
        </a>
        {props.name}
      </div>
      <div className="player-score">
        <Counter
          index={props.index}
          updatePlayerScore={props.updatePlayerScore}
          score={props.score}
        />
      </div>
    </div>
  );
};

Player.propTypes = {
  name: PropTypes.string.isRequired,
  index: PropTypes.number.isRequired,
  score: PropTypes.number.isRequired,
  removePlayer: PropTypes.func.isRequired,
  updatePlayer: PropTypes.func.isRequired,
  selectPlayer: PropTypes.func.isRequired
};

export default Player;
