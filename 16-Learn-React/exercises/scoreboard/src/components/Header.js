import React, { PropTypes } from 'react';
import Stats from './Stats';
import StopWatch from './Stopwatch';

const Header = props => {
  return(
    <div className="header">
      <Stats players={props.players} />
    <h1>Scoreboard</h1>
    <StopWatch />
    </div>
  );
};

Header.propTypes = {
  players: PropTypes.array.isRequired
};

export default Header;
